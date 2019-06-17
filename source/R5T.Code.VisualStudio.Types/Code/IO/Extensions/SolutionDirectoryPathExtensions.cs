using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public static class SolutionDirectoryPathExtensions
    {
        public static SolutionDirectoryName GetSolutionDirectoryName(this SolutionDirectoryPath solutionDirectoryPath)
        {
            var solutionDirectoryName = solutionDirectoryPath.GetDirectoryName().AsSolutionDirectoryName();
            return solutionDirectoryName;
        }
    }
}
