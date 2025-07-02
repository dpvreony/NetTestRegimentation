using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Xunit.v3;

namespace NetTestRegimentation.XUnit.LazyLoadingTestData
{
    public sealed class LazyLoadDataAttribute : DataAttribute
    {
        /// <inheritdoc/>
        public override ValueTask<IReadOnlyCollection<ITheoryDataRow>> GetData(
            MethodInfo testMethod,
            DisposalTracker disposalTracker) =>
            throw new NotSupportedException("Not used in lazy discovery");

        public override IEnumerable<IXunitTestCase> GetTestCases(
            ITestMethod testMethod, IAttributeInfo factAttribute)
        {
            // Simulate deferred test inputs
            yield return new LazyXunitTestCase(testMethod, new object[] { 1, 100L, true, "Alpha" });
            yield return new LazyXunitTestCase(testMethod, new object[] { 2, 200L, false, "Beta" });
        }
    }
}
}
