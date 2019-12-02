// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace NetTestRegimentation.UnitTests
{
    [ExcludeFromCodeCoverage]
    public static class ArgumentHelpers
    {

        public static async Task ThrowIfNullAsync<T>(
            T arg,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2>(
            T1 arg1,
            T2 arg2,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                paramName));
        }


        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                paramName));
        }


        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                paramName));
        }


        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                paramName));
        }


        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10,
            T11>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            T11 arg11,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10,
            T11,
            T12>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            T11 arg11,
            T12 arg12,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                paramName));
        }


        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10,
            T11,
            T12,
            T13>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            T11 arg11,
            T12 arg12,
            T13 arg13,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                paramName));
        }


        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10,
            T11,
            T12,
            T13,
            T14>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            T11 arg11,
            T12 arg12,
            T13 arg13,
            T14 arg14,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                arg14,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10,
            T11,
            T12,
            T13,
            T14,
            T15>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            T11 arg11,
            T12 arg12,
            T13 arg13,
            T14 arg14,
            T15 arg15,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                arg14,
                arg15,
                paramName));
        }

        public static async Task ThrowIfNullAsync<
            T1,
            T2,
            T3,
            T4,
            T5,
            T6,
            T7,
            T8,
            T9,
            T10,
            T11,
            T12,
            T13,
            T14,
            T15,
            T16>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            T4 arg4,
            T5 arg5,
            T6 arg6,
            T7 arg7,
            T8 arg8,
            T9 arg9,
            T10 arg10,
            T11 arg11,
            T12 arg12,
            T13 arg13,
            T14 arg14,
            T15 arg15,
            T16 arg16,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9,
                arg10,
                arg11,
                arg12,
                arg13,
                arg14,
                arg15,
                arg16,
                paramName));
        }

        public static void ThrowIfNull<T>(T arg, string paramName)

        {
            if (arg == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void ThrowIfNull<TArg1, TArg2>(
            TArg1 arg1,
            TArg2 arg2,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9>(
            TArg1 arg1,
            TArg2 arg2,
            TArg3 arg3,
            TArg4 arg4,
            TArg5 arg5,
            TArg6 arg6,
            TArg7 arg7,
            TArg8 arg8,
            TArg9 arg9,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
        }

        public static void ThrowIfNull<
            TArg1,
            TArg2,
            TArg3,
            TArg4,
            TArg5,
            TArg6,
            TArg7,
            TArg8,
            TArg9,
            TArg10>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
        }

        public static void ThrowIfNull<
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
            TArg11>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
        }

        public static void ThrowIfNull<
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
            TArg12>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
        }

        public static void ThrowIfNull<
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
            TArg13>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
        }

        public static void ThrowIfNull<
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
            TArg14>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
            ThrowIfNull(arg14, nameof(arg14));
        }

        public static void ThrowIfNull<
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
            TArg15>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
            ThrowIfNull(arg14, nameof(arg14));
            ThrowIfNull(arg15, nameof(arg15));
        }

        public static void ThrowIfNull<
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
            TArg16>(
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
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
            ThrowIfNull(arg3, nameof(arg3));
            ThrowIfNull(arg4, nameof(arg4));
            ThrowIfNull(arg5, nameof(arg5));
            ThrowIfNull(arg6, nameof(arg6));
            ThrowIfNull(arg7, nameof(arg7));
            ThrowIfNull(arg8, nameof(arg8));
            ThrowIfNull(arg9, nameof(arg9));
            ThrowIfNull(arg10, nameof(arg10));
            ThrowIfNull(arg11, nameof(arg11));
            ThrowIfNull(arg12, nameof(arg12));
            ThrowIfNull(arg13, nameof(arg13));
            ThrowIfNull(arg14, nameof(arg14));
            ThrowIfNull(arg15, nameof(arg15));
            ThrowIfNull(arg16, nameof(arg16));
        }
    }
}
