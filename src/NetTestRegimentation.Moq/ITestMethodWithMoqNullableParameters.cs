// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation.Moq
{
#pragma warning disable SA1402 // File may only contain a single type
    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<TArg>
        : ITestMethodWithNullableParameters<global::Moq.Mock<TArg>>
        where TArg : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>>
        where TArg1 : class
        where TArg2 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>,
            global::Moq.Mock<TArg11>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
        where TArg11 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>,
            global::Moq.Mock<TArg11>,
            global::Moq.Mock<TArg12>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
        where TArg11 : class
        where TArg12 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>,
            global::Moq.Mock<TArg11>,
            global::Moq.Mock<TArg12>,
            global::Moq.Mock<TArg13>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
        where TArg11 : class
        where TArg12 : class
        where TArg13 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>,
            global::Moq.Mock<TArg11>,
            global::Moq.Mock<TArg12>,
            global::Moq.Mock<TArg13>,
            global::Moq.Mock<TArg14>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
        where TArg11 : class
        where TArg12 : class
        where TArg13 : class
        where TArg14 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14,
            TArg15>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>,
            global::Moq.Mock<TArg11>,
            global::Moq.Mock<TArg12>,
            global::Moq.Mock<TArg13>,
            global::Moq.Mock<TArg14>,
            global::Moq.Mock<TArg15>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
        where TArg11 : class
        where TArg12 : class
        where TArg13 : class
        where TArg14 : class
        where TArg15 : class
    {
    }

    /// <inheritdoc />
    public interface ITestMethodWithMoqNullableParameters<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10,
            TArg11,
            TArg12,
            TArg13,
            TArg14,
            TArg15,
            TArg16>
        : ITestMethodWithNullableParameters<
            global::Moq.Mock<TArg1>,
            global::Moq.Mock<TArg2>,
            global::Moq.Mock<TArg3>,
            global::Moq.Mock<TArg4>,
            global::Moq.Mock<TArg5>,
            global::Moq.Mock<TArg6>,
            global::Moq.Mock<TArg7>,
            global::Moq.Mock<TArg8>,
            global::Moq.Mock<TArg9>,
            global::Moq.Mock<TArg10>,
            global::Moq.Mock<TArg11>,
            global::Moq.Mock<TArg12>,
            global::Moq.Mock<TArg13>,
            global::Moq.Mock<TArg14>,
            global::Moq.Mock<TArg15>,
            global::Moq.Mock<TArg16>>
        where TArg1 : class
        where TArg2 : class
        where TArg3 : class
        where TArg4 : class
        where TArg5 : class
        where TArg6 : class
        where TArg7 : class
        where TArg8 : class
        where TArg9 : class
        where TArg10 : class
        where TArg11 : class
        where TArg12 : class
        where TArg13 : class
        where TArg14 : class
        where TArg15 : class
        where TArg16 : class
    {
    }
#pragma warning restore SA1402 // File may only contain a single type
}
