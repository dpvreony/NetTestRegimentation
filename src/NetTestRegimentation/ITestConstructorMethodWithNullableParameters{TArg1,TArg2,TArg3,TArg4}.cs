// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for a constructor method that takes 4 nullable parameters.
    /// </summary>
    /// <typeparam name="TArg1">Type for the 1st argument.</typeparam>
    /// <typeparam name="TArg2">Type for the 2nd argument.</typeparam>
    /// <typeparam name="TArg3">Type for the 3rd argument.</typeparam>
    /// <typeparam name="TArg4">Type for the 4th argument.</typeparam>
    public interface ITestConstructorMethodWithNullableParameters<in TArg1, in TArg2, in TArg3, in TArg4>
        : ITestConstructorMethod, NetTestRegimentation.ITestMethodWithNullableParameters<TArg1, TArg2, TArg3, TArg4>
    {
    }
}
