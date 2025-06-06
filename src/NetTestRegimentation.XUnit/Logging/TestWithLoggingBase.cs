﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Microsoft.Extensions.Logging;
using Xunit;

namespace NetTestRegimentation.XUnit.Logging
{
    /// <summary>
    /// Base class for tests that require logging.
    /// </summary>
    public abstract class TestWithLoggingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestWithLoggingBase"/> class.
        /// </summary>
        /// <param name="output">XUnit Test Output Helper.</param>
        protected TestWithLoggingBase(ITestOutputHelper output)
        {
            LoggerFactory = new TestLogger(output);
            Logger = LoggerFactory.CreateLogger(GetType());
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        protected ILogger Logger { get; }

        /// <summary>
        /// Gets the test logger factory.
        /// </summary>
        protected TestLogger LoggerFactory { get; }
    }
}
