// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.IO;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine
{
    /// <summary>
    /// Model for command line arguments for the source generator tool.
    /// </summary>
    /// <param name="TestProjectPath">The path of the test project to generate code for.</param>
    /// <param name="WhatIf">Run a non-destructive generation, that produces a summary of what would happen.</param>
    public sealed record SourceGeneratorCommandLineArgModel(FileInfo TestProjectPath, bool WhatIf);
}
