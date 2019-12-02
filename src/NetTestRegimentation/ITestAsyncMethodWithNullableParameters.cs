// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace NetTestRegimentation
{
    public interface ITestAsyncMethodWithNullableParameters
    {
        Task ThrowsArgumentNullExceptionAsync();
    }
}
