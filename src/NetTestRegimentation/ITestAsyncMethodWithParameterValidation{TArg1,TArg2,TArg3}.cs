// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for Async Methods that contain 3 parameters that need validation.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    public interface ITestAsyncMethodWithParameterValidation<in TArg1, in TArg2, in TArg3>
    {
        /// <summary>
        /// Check to ensure parameters requiring validation throw <see cref="System.ArgumentException"/>.
        /// </summary>
        /// <param name="arg1">The 1st argument that takes validation.</param>
        /// <param name="arg2">The 2nd argument that takes validation.</param>
        /// <param name="arg3">The 3rd argument that takes validation.</param>
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
            string expectedParameterNameForException);
    }
}
