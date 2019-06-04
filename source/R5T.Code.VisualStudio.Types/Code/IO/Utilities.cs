using System;

using PathUtilities = R5T.NetStandard.IO.Paths.Utilities;


namespace R5T.Code.VisualStudio.IO
{
    public static class Utilities
    {
        /// <summary>
        /// The directory containing the project-file is the project-directory.
        /// </summary>
        public static ProjectDirectoryPath GetProjectDirectoryPath(ProjectFilePath projectFilePath)
        {
            var projectDirectoryPath = PathUtilities.GetDirectoryPath(projectFilePath).AsProjectDirectoryPath();
            return projectDirectoryPath;
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
