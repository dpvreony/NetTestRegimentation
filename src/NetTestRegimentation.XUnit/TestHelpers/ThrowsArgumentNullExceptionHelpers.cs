// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace NetTestRegimentation.XUnit.TestHelpers
{
    /// <summary>
    /// Helpers for performing tests to ensure <see cref="ArgumentNullException"/> is thrown.
    /// </summary>
    public static class ThrowsArgumentNullExceptionHelpers
    {
        /// <summary>
        /// Tests a method that validates the 1 argument is not null.
        /// </summary>
        /// <param name="testCode">Code to test.</param>
        /// <param name="arg">Input for the parameter that can be null.</param>
        /// <param name="expectedParameterName">Name of the parameter name the exception is expected to be thrown for.</param>
        /// <typeparam name="TArg">The type for the parameter that should not be null.</typeparam>
        public static void ThrowsArgumentNullException<TArg>(
            Action<TArg> testCode,
            TArg arg,
            string expectedParameterName)
        {
            var exception = Assert.Throws<ArgumentNullException>(() => testCode(arg));
            Assert.Equal(expectedParameterName, exception.ParamName);
        }
    }
}
