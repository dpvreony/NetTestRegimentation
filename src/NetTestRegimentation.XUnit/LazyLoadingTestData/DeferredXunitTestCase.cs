using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit.Sdk;
using Xunit.v3;

namespace NetTestRegimentation.XUnit.LazyLoadingTestData
{
    public class DeferredXunitTestCase : XunitTestCase
    {
        private int _id;
        private string _label;

        /// <summary>
        /// Called by the de-serializer; should only be called by deriving classes for de-serialization purposes
        /// </summary>
        [Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
        public DeferredXunitTestCase()
        {
            // This constructor is used by the de-serializer
            // It should not be called directly
            _id = 0;
            _label = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredXunitTestCase" /> class.
        /// </summary>
        /// <param name="testMethod">The test method this test case belongs to.</param>
        /// <param name="testCaseDisplayName">The display name for the test case.</param>
        /// <param name="uniqueID">The unique ID for the test case.</param>
        /// <param name="explicit">Indicates whether the test case was marked as explicit.</param>
        /// <param name="skipExceptions">The value obtained from <see cref="P:Xunit.v3.IFactAttribute.SkipExceptions" />.</param>
        /// <param name="skipReason">The value obtained from <see cref="P:Xunit.v3.IFactAttribute.Skip" />.</param>
        /// <param name="skipType">The value obtained from <see cref="P:Xunit.v3.IFactAttribute.SkipType" />.</param>
        /// <param name="skipUnless">The value obtained from <see cref="P:Xunit.v3.IFactAttribute.SkipUnless" />.</param>
        /// <param name="skipWhen">The value obtained from <see cref="P:Xunit.v3.IFactAttribute.SkipWhen" />.</param>
        /// <param name="traits">The optional traits list.</param>
        /// <param name="testMethodArguments">The optional arguments for the test method.</param>
        /// <param name="sourceFilePath">The optional source file in where this test case originated.</param>
        /// <param name="sourceLineNumber">The optional source line number where this test case originated.</param>
        /// <param name="timeout">The optional timeout for the test case (in milliseconds).</param>
        public DeferredXunitTestCase(
            int id,
            string label,
            IXunitTestMethod testMethod,
            string testCaseDisplayName,
            string uniqueID,
            bool @explicit,
            Type[]? skipExceptions = null,
            string? skipReason = null,
            Type? skipType = null,
            string? skipUnless = null,
            string? skipWhen = null,
            Dictionary<string, HashSet<string>>? traits = null,
            object?[]? testMethodArguments = null,
            string? sourceFilePath = null,
            int? sourceLineNumber = null,
            int? timeout = null)
            : base(
                testMethod,
                testCaseDisplayName,
                uniqueID,
                @explicit,
                skipExceptions,
                skipReason,
                skipType,
                skipUnless,
                skipWhen,
                traits,
                testMethodArguments,
                sourceFilePath,
                sourceLineNumber,
                timeout)
        {
            _id = id;
            _label = label;
        }

        public override string DisplayName => $"{TestMethod.Method.Name}({_id}, \"{_label}\")";

        public override void Serialize(IXunitSerializationInfo data)
        {
            base.Serialize(data);
            data.AddValue(nameof(_id), _id);
            data.AddValue(nameof(_label), _label);
        }

        public override void Deserialize(IXunitSerializationInfo data)
        {
            base.Deserialize(data);
            _id = data.GetValue<int>(nameof(_id));
            _label = data.GetValue<string>(nameof(_label));
        }

        public override async Task<RunSummary> RunAsync(IMessageSink diagnosticMessageSink,
                                                        IMessageBus messageBus,
                                                        object[] constructorArguments,
                                                        ExceptionAggregator aggregator,
                                                        CancellationTokenSource cancellationTokenSource)
        {
            // Lazy resolve actual parameters at execution time
            object[] realArgs = ResolveTestData(_id);

            return await new XunitTestCaseRunner(
                this, DisplayName, SkipReason, constructorArguments,
                realArgs, messageBus, aggregator, cancellationTokenSource)
                .RunAsync();
        }

        private object[] ResolveTestData(int id)
        {
            // Simulate expensive object creation
            if (id == 1)
                return new object[] { 1, 100L, true, "Alpha" };
            if (id == 2)
                return new object[] { 2, 200L, false, "Beta" };
            throw new InvalidOperationException("Unknown ID");
        }
    }
}
