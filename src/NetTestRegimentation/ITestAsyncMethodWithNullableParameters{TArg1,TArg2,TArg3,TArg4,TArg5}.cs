﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for a method that takes five nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    public interface ITestAsyncMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg1">The 1st nullable argument.</param>
        /// <param name="arg2">The 2nd nullable argument.</param>
        /// <param name="arg3">The 3rd nullable argument.</param>
        /// <param name="arg4">The 4th nullable argument.</param>
        /// <param name="arg5">The 5th nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        Task ThrowsArgumentNullExceptionAsync(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            string expectedParameterNameForException);
    }
}
