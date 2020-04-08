// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for Async Methods that contain nullable parameters.
    /// </summary>
    /// <remarks>
    /// This is a catch all interface. You should look to use one of the generic versions.
    /// </remarks>
    public interface ITestAsyncMethodWithNullableParameters
    {
        /// <summary>
        /// Check to ensure nullable parameters throw <see cref="System.ArgumentNullException"/>.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task ThrowsArgumentNullExceptionAsync();
    }
}
