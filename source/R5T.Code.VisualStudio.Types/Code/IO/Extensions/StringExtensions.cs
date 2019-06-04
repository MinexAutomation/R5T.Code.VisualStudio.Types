using System;


namespace R5T.Code.VisualStudio.IO.Extensions
{
    public static class StringExtensions
    {
        public static ProjectDirectoryName AsProjectDirectoryName(this string value)
        {
            var projectDirectoryName = new ProjectDirectoryName(value);
            return projectDirectoryName;
        }

        public static ProjectDirectoryPath AsProjectDirectoryPath(this string value)
        {
            var projectDirectoryPath = new ProjectDirectoryPath(value);
            return projectDirectoryPath;
        }

        public static ProjectFileName AsProjectFileName(this string value)
        {
            var projectFileName = new ProjectFileName(value);
            return projectFileName;
        }

        public static ProjectFilePath AsProjectFilePath(this string value)
        {
            var projectFilePath = new ProjectFilePath(value);
            return projectFilePath;
        }

        public static SolutionDirectoryName AsSolutionDirectoryName(this string value)
        {
            var solutionDirectoryName = new SolutionDirectoryName(value);
            return solutionDirectoryName;
        }

        public static SolutionDirectoryPath AsSolutionDirectoryPath(this string value)
        {
            var solutionDirectoryPath = new SolutionDirectoryPath(value);
            return solutionDirectoryPath;
        }

        public static SolutionFileName AsSolutionFileName(this string value)
        {
            var solutionFileName = new SolutionFileName(value);
            return solutionFileName;
        }

        public static SolutionFilePath AsSolutionFilePath(this string value)
        {
            var solutionFilePath = new SolutionFilePath(value);
            return solutionFilePath;
        }
    }
}
