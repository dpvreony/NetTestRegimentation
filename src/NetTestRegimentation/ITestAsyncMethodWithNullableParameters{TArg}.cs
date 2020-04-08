// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for a method that a nullable parameter.
    /// </summary>
    /// <typeparam name="TArg">Type for the argument.</typeparam>
    public interface ITestAsyncMethodWithNullableParameters<in TArg>
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <param name="arg">The nullable argument.</param>
        /// <param name="expectedParameterNameForException">
        /// The name of the parameter expected to throw an exception.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        Task ThrowsArgumentNullExceptionAsync(
            TArg arg,
            string expectedParameterNameForException);
    }
}
