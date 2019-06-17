using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public static class ProjectDirectoryPathExtensions
    {
        public static ProjectDirectoryName GetProjectDirectoryName(this ProjectDirectoryPath projectDirectoryPath)
        {
            var projectDirectoryName = projectDirectoryPath.GetDirectoryName().AsProjectDirectoryName();
            return projectDirectoryName;
        }
    }
}
