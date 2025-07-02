// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using Microsoft.Build.Locator;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.MSBuild
{
    /// <summary>
    /// Hack wrapper for <see cref="MSBuildLocator"/> as you have to initialise MSBuild in a method not actually using it.
    /// https://learn.microsoft.com/en-gb/visualstudio/msbuild/find-and-use-msbuild-versions?view=vs-2022#use-microsoftbuildlocator for more information.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public sealed class MSBuildLocatorWrapper
    {
        private MSBuildLocatorWrapper(VisualStudioInstance visualStudioInstance)
        {
            VisualStudioInstance = visualStudioInstance;
        }

        /// <summary>
        /// Gets the registered Visual Studio instance.
        /// </summary>
        public VisualStudioInstance VisualStudioInstance { get; }

        /// <summary>
        /// Registers latest version of Visual Studio if any version is installed.
        /// </summary>
        /// <returns>Wrapper instance for <see cref="MSBuildLocator"/>.</returns>
        public static MSBuildLocatorWrapper RegisterLatestVersionOfVisualStudio()
        {
            var visualStudioInstance = MSBuildLocatorHelpers.GetLatestVersionOfVisualStudio();

            if (visualStudioInstance == null)
            {
                throw new InvalidOperationException("No instance of Visual Studio detected");
            }

            MSBuildLocator.RegisterInstance(visualStudioInstance);

            return new MSBuildLocatorWrapper(visualStudioInstance);
        }
    }
}
