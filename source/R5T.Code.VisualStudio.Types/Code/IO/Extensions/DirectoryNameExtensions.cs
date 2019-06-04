using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public static class DirectoryNameExtensions
    {
        public static ProjectDirectoryName AsProjectDirectoryName(this DirectoryName directoryName)
        {
            var projectDirectoryName = new ProjectDirectoryName(directoryName.Value);
            return projectDirectoryName;
        }

        public static SolutionDirectoryName AsSolutionDirectoryName(this DirectoryName directoryName)
        {
            var solutionDirectoryName = new SolutionDirectoryName(directoryName.Value);
            return solutionDirectoryName;
        }
    }
}
