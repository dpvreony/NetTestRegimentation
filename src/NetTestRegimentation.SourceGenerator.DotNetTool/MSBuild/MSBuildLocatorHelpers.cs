// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Linq;
using Microsoft.Build.Locator;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.MSBuild
{
    /// <summary>
    /// Helper class for MSBuildLocator.
    /// </summary>
    /// <remarks>
    /// These can be extensions once C# 14 is available.
    /// </remarks>
    // ReSharper disable once InconsistentNaming
    public static class MSBuildLocatorHelpers
    {
        /// <summary>
        /// Gets the latest version of Visual Studio if any version is installed.
        /// </summary>
        /// <returns>Visual Studio Instance for the latest version installed, or null if no instance is installed.</returns>
        public static VisualStudioInstance? GetLatestVersionOfVisualStudio()
        {
            return MSBuildLocator.QueryVisualStudioInstances()
                .MaxBy(instance => instance.Version);
        }
    }
}
