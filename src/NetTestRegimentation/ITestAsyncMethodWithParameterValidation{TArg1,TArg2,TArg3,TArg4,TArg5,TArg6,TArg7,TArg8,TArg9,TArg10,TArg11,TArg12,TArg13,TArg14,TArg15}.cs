﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for Async Methods that contain 15 parameters that need validation.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    /// <typeparam name="TArg5">Type for the 5th argument.</typeparam>
    /// <typeparam name="TArg6">Type for the 6th argument.</typeparam>
    /// <typeparam name="TArg7">Type for the 7th argument.</typeparam>
    /// <typeparam name="TArg8">Type for the 8th argument.</typeparam>
    /// <typeparam name="TArg9">Type for the 9th argument.</typeparam>
    /// <typeparam name="TArg10">Type for the 10th argument.</typeparam>
    /// <typeparam name="TArg11">Type for the 11th argument.</typeparam>
    /// <typeparam name="TArg12">Type for the 12th argument.</typeparam>
    /// <typeparam name="TArg13">Type for the 13th argument.</typeparam>
    /// <typeparam name="TArg14">Type for the 14th argument.</typeparam>
    /// <typeparam name="TArg15">Type for the 15th argument.</typeparam>
    public interface ITestAsyncMethodWithParameterValidation<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14,
        in TArg15>
    {
        /// <summary>
        /// Check to ensure parameters requiring validation throw <see cref="System.ArgumentException"/>.
        /// </summary>
        /// <param name="arg1">The 1st argument that takes validation.</param>
        /// <param name="arg2">The 2nd argument that takes validation.</param>
        /// <param name="arg3">The 3rd argument that takes validation.</param>
        /// <param name="arg4">The 4th argument that takes validation.</param>
        /// <param name="arg5">The 5th argument that takes validation.</param>
        /// <param name="arg6">The 6th argument that takes validation.</param>
        /// <param name="arg7">The 7th argument that takes validation.</param>
        /// <param name="arg8">The 8th argument that takes validation.</param>
        /// <param name="arg9">The 9th argument that takes validation.</param>
        /// <param name="arg10">The 10th argument that takes validation.</param>
        /// <param name="arg11">The 11th argument that takes validation.</param>
        /// <param name="arg12">The 12th argument that takes validation.</param>
        /// <param name="arg13">The 13th argument that takes validation.</param>
        /// <param name="arg14">The 14th argument that takes validation.</param>
        /// <param name="arg15">The 15th argument that takes validation.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        Task ThrowsArgumentExceptionAsync(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            TArg15 arg15,
            string expectedParameterNameForException);
    }
}
