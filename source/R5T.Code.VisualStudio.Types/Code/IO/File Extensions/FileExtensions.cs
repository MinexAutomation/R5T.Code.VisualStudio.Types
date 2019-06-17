using System;


namespace R5T.Code.VisualStudio.IO
{
    public static class FileExtensions
    {
        /// <summary>
        /// The <see cref="SolutionFileExtension.Instance"/>.
        /// </summary>
        public static SolutionFileExtension Sln => SolutionFileExtension.Instance;
        /// <summary>
        /// The <see cref="CSharpProjectFileExtension.Instance"/>.
        /// </summary>
        public static readonly CSharpProjectFileExtension Csproj = CSharpProjectFileExtension.Instance;
    }
}
