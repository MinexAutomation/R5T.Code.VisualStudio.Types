using System;


namespace R5T.Code.VisualStudio.Extensions
{
    public static class StringExtensions
    {
        public static ProjectName AsProjectName(this string value)
        {
            var projectName = new ProjectName(value);
            return projectName;
        }

        public static SolutionName AsSolutionName(this string value)
        {
            var solutionName = new SolutionName(value);
            return solutionName;
        }
    }
}
