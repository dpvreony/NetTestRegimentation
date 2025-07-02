// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Microsoft.Build.Evaluation;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.MSBuild
{
    /// <summary>
    /// Extension methods for <see cref="Project"/>.
    /// </summary>
    public static class ProjectExtensions
    {
        /// <summary>
        /// Gets the project references for a given project.
        /// </summary>
        /// <param name="project">The project to process.</param>
        /// <returns>Collection of project references.</returns>
        public static ICollection<ProjectItem> GetProjectReferences(this Project project)
        {
            return project.GetItems("ProjectReference");
        }
    }
}
