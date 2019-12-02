// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace NetTestRegimentation.UnitTests
{
    public static class ObjectArrayHelper
    {
        public static object[][] GetArgObjectArrayOfArray(int size)
        {
            var result = new List<object[]>(size);
            for (int i = 1; i <= size; i++)
            {
                result.Add(GetArgObjectArray(size, i));
            }

            return result.ToArray();
        }

        public static object[] GetArgObjectArray(
            int size,
            int argumentToLeaveNull)
        {
            var result = new List<object>(size + 1);
            for (int i = 1; i <= size; i++)
            {
                result.Add((i == argumentToLeaveNull) ? null : new FakeObject());
            }

            result.Add($"arg{argumentToLeaveNull}");

            return result.ToArray();
        }

        public static object[][] GetMoqArgObjectArrayOfArray(int size)
        {
            var result = new List<object[]>(size);
            for (int i = 1; i <= size; i++)
            {
                result.Add(GetMoqArgObjectArray(size, i));
            }

            return result.ToArray();
        }

        public static object[] GetMoqArgObjectArray(
            int size,
            int argumentToLeaveNull)
        {
            var result = new List<object>(size + 1);
            for (int i = 1; i <= size; i++)
            {
                result.Add((i == argumentToLeaveNull) ? null : new Mock<FakeObject>());
            }

            result.Add($"arg{argumentToLeaveNull}");

            return result.ToArray();
        }
    }
}
