using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public sealed class SolutionFileExtension : FileExtension
    {
        /// <summary>
        /// The "sln" Visual Studio solution file-extension.
        /// </summary>
        public const string SolutionFileExtensionString = "sln";


        #region Static

        /// <summary>
        /// The <see cref="SolutionFileExtension.SolutionFileExtensionString"/> value.
        /// </summary>
        public static readonly SolutionFileExtension Instance = new SolutionFileExtension(SolutionFileExtension.SolutionFileExtensionString);

        #endregion


        private SolutionFileExtension(string value)
            : base(value)
        {
        }
    }
}
