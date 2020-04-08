// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for a constructor method that takes 2 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    public interface ITestConstructorMethodWithNullableParameters<in TArg1, in TArg2>
        : ITestConstructorMethod, NetTestRegimentation.ITestMethodWithNullableParameters<TArg1, TArg2>
    {
    }
}
