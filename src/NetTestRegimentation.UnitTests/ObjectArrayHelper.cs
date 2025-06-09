// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Globalization;

namespace NetTestRegimentation.UnitTests
{
    /// <summary>
    /// Helpers for producing testable object arrays for unit testing.
    /// </summary>
    public static class ObjectArrayHelper
    {
        /// <summary>
        /// Gets an array of test objects for unit test member data sources.
        /// </summary>
        /// <param name="size">Size of the array.</param>
        /// <returns>2 dimension array. 1st dimension is test scenario, 2nd is the arguments the method takes.</returns>
        public static object[][] GetArgObjectArrayOfArray(int size)
        {
            var result = new List<object[]>(size);
            for (int i = 1; i <= size; i++)
            {
                result.Add(GetArgObjectArray(size, i));
            }

            return result.ToArray();
        }

        /// <summary>
        /// Gets an array of test objects for unit test member data sources.
        /// </summary>
        /// <param name="size">Size of the array.</param>
        /// <param name="argumentToLeaveNull">1 based index of the argument to leave null.</param>
        /// <returns>array. this is for the number of arguments the method takes.</returns>
        public static object[] GetArgObjectArray(
            int size,
            int argumentToLeaveNull)
        {
            var result = new List<object>(size + 1);
            for (int i = 1; i <= size; i++)
            {
                result.Add((i == argumentToLeaveNull) ? null : new FakeObject());
            }

            result.Add($"arg{(size > 1 ? argumentToLeaveNull.ToString(NumberFormatInfo.InvariantInfo) : string.Empty)}");

            return result.ToArray();
        }
    }
}
