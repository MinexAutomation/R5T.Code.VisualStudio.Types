﻿using System;

using R5T.NetStandard.IO.Paths;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Code.VisualStudio.IO
{
    public static class Utilities
    {
        public static ProjectFileName GetCSharpProjectFileName(FileNameWithoutExtension projectfileNameWithoutExtension)
        {
            var projectFileName = PathUtilities.GetFileName(projectfileNameWithoutExtension, CSharpProjectFileExtension.Instance).AsProjectFileName();
            return projectFileName;
        }

        public static ProjectFilePath GetProjectFilePath(ProjectDirectoryPath projectDirectoryPath, ProjectFileName projectFileName)
        {
            var projectFilePath = PathUtilities.GetFilePath(projectDirectoryPath, projectFileName).AsProjectFilePath();
            return projectFilePath;
        }

        /// <summary>
        /// The directory containing the project-file is the project-directory.
        /// </summary>
        public static ProjectDirectoryPath GetProjectDirectoryPath(ProjectFilePath projectFilePath)
        {
            var projectDirectoryPath = PathUtilities.GetDirectoryPath(projectFilePath).AsProjectDirectoryPath();
            return projectDirectoryPath;
        }

        public static SolutionFileName GetSolutionFileName(FileNameWithoutExtension solutionFileNameWithoutExtension)
        {
            var solutionFileName = PathUtilities.GetFileName(solutionFileNameWithoutExtension, FileExtensions.Sln).AsSolutionFileName();
            return solutionFileName;
        }

        public static SolutionFilePath GetSolutionFilePath(SolutionDirectoryPath solutionDirectoryPath, SolutionFileName solutionFileName)
        {
            var solutionFilePath = PathUtilities.GetFilePath(solutionDirectoryPath, solutionFileName).AsSolutionFilePath();
            return solutionFilePath;
        }

        /// <summary>
        /// The directory containing the project-directory is the solution-directory.
        /// </summary>
        public static SolutionDirectoryPath GetSolutionDirectoryPath(ProjectDirectoryPath projectDirectoryPath)
        {
            var solutionDirectoryPath = PathUtilities.GetParentDirectoryPath(projectDirectoryPath).AsSolutionDirectoryPath();
            return solutionDirectoryPath;
        }

        /// <summary>
        /// The directory containing the solution-file is the solution-directory.
        /// </summary>
        public static SolutionDirectoryPath GetSolutionDirectoryPath(SolutionFilePath solutionFilePath)
        {
            var solutionDirectoryPath = PathUtilities.GetDirectoryPath(solutionFilePath).AsSolutionDirectoryPath();
            return solutionDirectoryPath;
        }
    }
}
