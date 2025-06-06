﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading;
using Microsoft.Extensions.Logging;

namespace NetTestRegimentation.XUnit.Logging;

internal sealed class TestLoggerLogger : ILogger
{
    private static readonly AsyncLocal<Wrapper> _currentScopeStack = new();
    private readonly TestLogger _logger;
    private readonly string _categoryName;

    public TestLoggerLogger(string categoryName, TestLogger logger)
    {
        _logger = logger;
        _categoryName = categoryName;
    }

    private static ImmutableStack<object> CurrentScopeStack
    {
        get => _currentScopeStack.Value?.Value ?? ImmutableStack.Create<object>();
        set => _currentScopeStack.Value = new Wrapper(value);
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        Whipstaff.Runtime.Exceptions.ArgumentNullException.ThrowIfNull(state);

        if (!_logger.IsEnabled(_categoryName, logLevel))
        {
            return;
        }

        object[] scopes = _logger.Options.IncludeScopes ? CurrentScopeStack.Reverse().ToArray() : [];
        var logEntry = new LogEntry(_logger.Options.GetNow(), _categoryName, logLevel, state!, (s, e) => formatter((TState)s, e))
        {
            Date = _logger.Options.GetNow(),
            LogLevel = logLevel,
            EventId = eventId,
            Exception = exception,
            Scopes = scopes
        };

        switch (state)
        {
            case IDictionary<string, object> logDictionary:
                foreach (var property in logDictionary)
                {
                    logEntry.Properties[property.Key] = property.Value;
                }

                break;
        }

        foreach (object scope in scopes)
        {
            if (!(scope is IDictionary<string, object> scopeData))
            {
                continue;
            }

            foreach (var property in scopeData)
            {
                logEntry.Properties[property.Key] = property.Value;
            }
        }

        _logger.AddLogEntry(logEntry);
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return _logger.IsEnabled(_categoryName, logLevel);
    }

    public IDisposable? BeginScope<TState>(TState state)
        where TState : notnull
    {
        return Push(state);
    }

    private static IDisposable Push(object state)
    {
        CurrentScopeStack = CurrentScopeStack.Push(state);
        return Disposable.Create(Pop);
    }

    private static void Pop()
    {
        CurrentScopeStack = CurrentScopeStack.Pop();
    }

    private sealed class Wrapper
    {
        internal Wrapper(ImmutableStack<object> value)
        {
            Value = value;
        }

        public ImmutableStack<object> Value { get; }
    }
}
