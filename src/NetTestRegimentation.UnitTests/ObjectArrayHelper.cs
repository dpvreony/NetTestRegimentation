using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace NetTestRegimentation.UnitTests
{
    public static class ObjectArrayHelper
    {
        public static object[][] GetMoqArgObjectArrayOfArray(int size)
        {
            var result = new List<object[]>(size);
            for (int i = 1; i < size; i++)
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
            for (int i = 1; i < size; i++)
            {
                result.Add((i == argumentToLeaveNull) ? null : new Mock<FakeObject>());
            }

            result.Add($"arg{argumentToLeaveNull}");

            return result.ToArray();
        }
    }
}
