// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using NetTestRegimentation.XUnit.Runtime;

namespace NetTestRegimentation.XUnit.Theories.ArgumentNullException
{
    /// <summary>
    /// Model for testing parameter validation with a valid value.
    /// </summary>
    /// <typeparam name="TResult">The input type for the parameter being tested.</typeparam>
    public sealed class NamedParameterInput<TResult>
        where TResult : notnull
    {
        private readonly Func<TResult> _validValueFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedParameterInput{TResult}"/> class.
        /// </summary>
        /// <param name="name">Name of the parameter being tested.</param>
        /// <param name="validValueFunc">Func to return a valid value for the parameter being tested.</param>
        public NamedParameterInput(string name, Func<TResult> validValueFunc)
        {
            name.ThrowIfNullOrWhitespace(nameof(name));
            Name = name;
            _validValueFunc = validValueFunc ?? throw new System.ArgumentNullException(nameof(validValueFunc));
        }

        /// <summary>
        /// Gets the name of the parameter being tested.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a valid value for the parameter being tested.
        /// </summary>
        /// <returns>Valid value to use in tests.</returns>
        public TResult ValidValue() => _validValueFunc();
    }
}
