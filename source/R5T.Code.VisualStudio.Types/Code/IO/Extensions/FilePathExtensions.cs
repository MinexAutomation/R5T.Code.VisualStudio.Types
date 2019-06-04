using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public static class FilePathExtensions
    {
        public static ProjectFilePath AsProjectFilePath(this FilePath filePath)
        {
            var projectFilePath = new ProjectFilePath(filePath.Value);
            return projectFilePath;
        }

        public static SolutionFilePath AsSolutionFilePath(this FilePath filePath)
        {
            var solutionFilePath = new SolutionFilePath(filePath.Value);
            return solutionFilePath;
        }
    }
}
