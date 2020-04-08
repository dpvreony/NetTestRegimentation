// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for Async Methods that contain parameters that need validation.
    /// </summary>
    /// <remarks>
    /// This is a catch all interface. You should look to use one of the generic versions.
    /// </remarks>
    public interface ITestAsyncMethodWithParameterValidation
    {
        /// <summary>
        /// Check to ensure parameters that require validation throw <see cref="System.ArgumentException"/>.
        /// </summary>
        /// <remarks>
        /// Consider the use of <see cref="ITestAsyncMethodWithNullableParameters"/> or <see cref="ITestMethodWithRangeParameters"/> where it makes sense.
        /// </remarks>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task ThrowsArgumentExceptionAsync();
    }
}
