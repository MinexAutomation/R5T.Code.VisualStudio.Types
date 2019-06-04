using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public static class FileNameExtensions
    {
        public static ProjectFileName AsProjectFileName(this FileName fileName)
        {
            var projectFileName = new ProjectFileName(fileName.Value);
            return projectFileName;
        }

        public static SolutionFileName AsSolutionFileName(this FileName fileName)
        {
            var solutionFileName = new SolutionFileName(fileName.Value);
            return solutionFileName;
        }
    }
}
