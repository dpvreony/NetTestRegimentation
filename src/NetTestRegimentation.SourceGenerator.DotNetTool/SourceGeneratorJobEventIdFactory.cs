// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using Microsoft.Extensions.Logging;

namespace NetTestRegimentation.SourceGenerator.DotNetTool
{
    internal static class SourceGeneratorJobEventIdFactory
    {
        internal static EventId StartingHandleCommand() => new(1, nameof(StartingHandleCommand));

        internal static EventId FailedToFindRootCommand() => new(2, nameof(StartingHandleCommand));

        internal static EventId UnhandledException() => new(3, nameof(UnhandledException));

        internal static EventId NoGeneratedCode() => new(4, nameof(NoGeneratedCode));

        internal static EventId GeneratedCode() => new(5, nameof(GeneratedCode));

        internal static EventId GeneratedCodeFile() => new(6, nameof(GeneratedCodeFile));
    }
}
