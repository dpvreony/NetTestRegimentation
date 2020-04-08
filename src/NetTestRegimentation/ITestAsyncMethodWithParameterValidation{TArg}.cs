// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for Async Methods that contain 1 parameter that need validation.
    /// </summary>
    /// <typeparam name="TArg">Type for the argument.</typeparam>
    public interface ITestAsyncMethodWithParameterValidation<in TArg>
    {
        /// <summary>
        /// Check to ensure parameters requiring validation throw <see cref="System.ArgumentException"/>.
        /// </summary>
        /// <param name="arg">The argument that takes validation.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        Task ThrowsArgumentExceptionAsync(
            TArg arg,
            string expectedParameterNameForException);
    }
}
