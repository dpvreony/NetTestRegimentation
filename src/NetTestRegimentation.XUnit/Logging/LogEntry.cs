﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace NetTestRegimentation.XUnit.Logging
{
    /// <summary>
    /// Represents a log entry.
    /// </summary>
    public sealed class LogEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntry"/> class.
        /// </summary>
        /// <param name="date">The date and time of the log entry.</param>
        /// <param name="categoryName">The category name of the log entry.</param>
        /// <param name="logLevel">The log level of the log entry.</param>
        /// <param name="state">The state of the log entry.</param>
        /// <param name="formatter">The formatter of the log entry.</param>
        public LogEntry(DateTimeOffset date, string categoryName, LogLevel logLevel, object state, Func<object, Exception?, string> formatter)
        {
            Date = date;
            CategoryName = categoryName;
            LogLevel = logLevel;
            State = state;
            Formatter = formatter;
        }

        /// <summary>
        /// Gets or sets the date and time of the log entry.
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the category name of the log entry.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the log level of the log entry.
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the scopes of the log entry.
        /// </summary>
#pragma warning disable CA1819 // Properties should not return arrays
        public object[]? Scopes { get; set; }
#pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// Gets or sets the event id of the log entry.
        /// </summary>
        public EventId? EventId { get; set; }

        /// <summary>
        /// Gets or sets the state of the log entry.
        /// </summary>
        public object State { get; set; }

        /// <summary>
        /// Gets or sets the exception of the log entry.
        /// </summary>
        public Exception? Exception { get; set; }

        /// <summary>
        /// Gets or sets the formatter of the log entry.
        /// </summary>
        public Func<object, Exception?, string> Formatter { get; set; }

        /// <summary>
        /// Gets the properties of the log entry.
        /// </summary>
        public IDictionary<string, object> Properties { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Gets the message of the log entry.
        /// </summary>
        public string Message => Formatter(State, Exception);

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
#pragma warning disable CA1305 // Specify IFormatProvider
#pragma warning disable CA1304 // Specify CultureInfo
#pragma warning disable CA1311 // Specify a culture or use an invariant version
            return string.Concat(string.Empty, Date.ToString("mm:ss.fff"), " ", LogLevel.ToString().Substring(0, 1).ToUpper(), ": ", Message, " - ", CategoryName);
#pragma warning restore CA1311 // Specify a culture or use an invariant version
#pragma warning restore CA1304 // Specify CultureInfo
#pragma warning restore CA1305 // Specify IFormatProvider
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <param name="useFullCategory">
        /// Whether to use the full category name or just the last part.
        /// </param>
        /// <returns>A string that represents the current object.</returns>
        public string ToString(bool useFullCategory)
        {
            string category = CategoryName;
            if (!useFullCategory)
            {
                int lastDot = category.LastIndexOf('.');
                if (lastDot >= 0)
                {
                    category = category.Substring(lastDot + 1);
                }
            }

#pragma warning disable CA1305 // Specify IFormatProvider
#pragma warning disable CA1304 // Specify CultureInfo
#pragma warning disable CA1311 // Specify a culture or use an invariant version
            return string.Concat(string.Empty, Date.ToString("mm:ss.fff"), " ", LogLevel.ToString().Substring(0, 1).ToUpper(), ": ", Message, " - ", category);
#pragma warning restore CA1311 // Specify a culture or use an invariant version
#pragma warning restore CA1304 // Specify CultureInfo
#pragma warning restore CA1305 // Specify IFormatProvider
        }
    }
}
