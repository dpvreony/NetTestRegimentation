// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace NetTestRegimentation
{
    public interface ITestMethodWithRangeParameters<in TArg>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg arg,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2, in TArg3>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2, in TArg3, in TArg4>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14,
        in TArg15>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            TArg15 arg15,
            string expectedParameterNameForException);
    }

    public interface ITestMethodWithRangeParameters<
        in TArg1,
        in TArg2,
        in TArg3,
        in TArg4,
        in TArg5,
        in TArg6,
        in TArg7,
        in TArg8,
        in TArg9,
        in TArg10,
        in TArg11,
        in TArg12,
        in TArg13,
        in TArg14,
        in TArg15,
        in TArg16>
    {
        void ThrowsArgumentOutOfRangeException(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            TArg10 arg10,
            TArg11 arg11,
            TArg12 arg12,
            TArg13 arg13,
            TArg14 arg14,
            TArg15 arg15,
            TArg16 arg16,
            string expectedParameterNameForException);
    }

}
