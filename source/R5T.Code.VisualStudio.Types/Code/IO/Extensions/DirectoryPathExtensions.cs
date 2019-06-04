using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public static class DirectoryPathExtensions
    {
        public static ProjectDirectoryPath AsProjectDirectoryPath(this DirectoryPath directoryPath)
        {
            var projectDirectoryPath = new ProjectDirectoryPath(directoryPath.Value);
            return projectDirectoryPath;
        }

        public static SolutionDirectoryPath AsSolutionDirectoryPath(this DirectoryPath directoryPath)
        {
            var solutionDirectoryPath = new SolutionDirectoryPath(directoryPath.Value);
            return solutionDirectoryPath;
        }
    }
}
