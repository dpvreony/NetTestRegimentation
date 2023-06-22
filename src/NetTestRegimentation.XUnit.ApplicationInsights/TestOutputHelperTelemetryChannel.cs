// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Microsoft.ApplicationInsights.Channel;
using Xunit.Abstractions;

namespace NetTestRegimentation.XUnit.ApplicationInsights
{
    /// <summary>
    /// Application Insights telemetry channel that writes to the XUnit test output.
    /// </summary>
    public sealed class TestOutputHelperTelemetryChannel : ITelemetryChannel
    {
        private readonly ITestOutputHelper _testOutputHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestOutputHelperTelemetryChannel"/> class.
        /// </summary>
        /// <param name="testOutputHelper">XUnit Test Output Helper instance for the current test.</param>
        public TestOutputHelperTelemetryChannel(ITestOutputHelper testOutputHelper)
        {
            ArgumentNullException.ThrowIfNull(testOutputHelper);
            _testOutputHelper = testOutputHelper;
            EndpointAddress = string.Empty;
        }

        /// <inheritdoc/>
        public bool? DeveloperMode { get; set; }

        /// <inheritdoc/>
        public string EndpointAddress { get; set; }

        /// <inheritdoc/>
        public void Dispose()
        {
        }

        /// <inheritdoc/>
        public void Flush()
        {
        }

        /// <inheritdoc/>
        public void Send(ITelemetry item)
        {
            if (item == null)
            {
                return;
            }

            // TODO: confirm tostring vs serialization.
            var message = item.ToString();

            _testOutputHelper.WriteLine(message);
        }
    }
}
