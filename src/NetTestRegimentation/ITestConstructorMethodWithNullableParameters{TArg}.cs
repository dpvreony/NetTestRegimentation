// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation
{
    /// <summary>
    /// Unit Tests for a constructor method that takes a nullable parameter.
    /// </summary>
    /// <typeparam name="TArg">The type for the argument.</typeparam>
    public interface ITestConstructorMethodWithNullableParameters<in TArg>
        : ITestConstructorMethod, NetTestRegimentation.ITestMethodWithNullableParameters<TArg>
    {
    }
}
