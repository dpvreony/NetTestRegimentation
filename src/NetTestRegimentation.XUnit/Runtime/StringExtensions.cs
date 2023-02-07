// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;

namespace NetTestRegimentation.XUnit.Runtime
{
    /// <summary>
    /// Extensions for working with strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Validates the string is not null or whitespace.
        /// </summary>
        /// <param name="instance">String to check.</param>
        /// <param name="paramName">Name of the parameter. Currently has to be passed as we're targeting netstandard 2.0 so can't use CallerArgumentExpression.</param>
        /// <exception cref="System.ArgumentNullException">The string is null.</exception>
        /// <exception cref="System.ArgumentException">The string is whitespace.</exception>
        public static void ThrowIfNullOrWhitespace(this string? instance, string paramName)
        {
            if (instance == null)
            {
                throw new System.ArgumentNullException(paramName);
            }

            if (string.IsNullOrWhiteSpace(instance))
            {
                throw new System.ArgumentException("string must not be empty", paramName);
            }
        }
    }
}
