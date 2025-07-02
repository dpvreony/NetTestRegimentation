// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public static string[] GetProjectReferences(this Project project)
        {
            var projectReferences = new HashSet<string>();
            EnumerateProjectReferences(project, projectReferences);

            return projectReferences.ToArray();
        }

        private static void EnumerateProjectReferences(
            Project project,
            HashSet<string> projectReferences)
        {
            var csprojPath = project.FullPath;
            foreach (var projectItem in project.GetItems("ProjectReference"))
            {
                var fullPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(csprojPath), projectItem.EvaluatedInclude));
                if (projectReferences.Add(fullPath))
                {
                    var referencedProject = new Project(fullPath);
                    EnumerateProjectReferences(referencedProject, projectReferences);
                }
            }
        }
    }
}
