using System;


namespace R5T.Code.VisualStudio.IO
{
    public static class FileExtensions
    {
        /// <summary>
        /// The Visual Studio Solution file-extension.
        /// </summary>
        public static readonly SolutionFileExtension Sln = SolutionFileExtension.Instance;
        /// <summary>
        /// The Visual Studio C#-project file-extension.
        /// </summary>
        public static readonly CSharpProjectFileExtension Csproj = CSharpProjectFileExtension.Instance;
    }
}
