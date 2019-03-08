using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetTestRegimentation.UnitTests
{
    public static class Helper
    {

        public static async Task ThrowIfNullAsync<T>(T arg, string paramName)
        {
            await Task.Run(() => ThrowIfNull(arg, paramName));
        }

        public static async Task ThrowIfNullAsync<T1, T2>(
            T1 arg1,
            T2 arg2,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(arg1, arg2, paramName));
        }

        public static async Task ThrowIfNullAsync<T1, T2, T3>(
            T1 arg1,
            T2 arg2,
            T3 arg3,
            string paramName)
        {
            await Task.Run(() => ThrowIfNull(arg1, arg2, arg3, paramName));
        }

        private static void ThrowIfNull<T>(T arg, string paramName)
        {
            if (arg == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        private static void ThrowIfNull<TArg1, TArg2>(
            TArg1 arg1,
            TArg2 arg2,
            string paramName)
        {
            ThrowIfNull(arg1, nameof(arg1));
            ThrowIfNull(arg2, nameof(arg2));
        }

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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

        private static void ThrowIfNull<
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
