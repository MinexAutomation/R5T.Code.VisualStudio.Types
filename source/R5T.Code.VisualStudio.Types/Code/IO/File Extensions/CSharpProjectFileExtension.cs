using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public sealed class CSharpProjectFileExtension : FileExtension
    {
        /// <summary>
        /// The Visual Studio C#-project file-extension.
        /// </summary>
        public const string CSharpProjectFileExtensionString = "csproj";


        #region Static

        /// <summary>
        /// The <see cref="CSharpProjectFileExtension.CSharpProjectFileExtensionString"/> value.
        /// </summary>
        public static readonly CSharpProjectFileExtension Instance = new CSharpProjectFileExtension(CSharpProjectFileExtension.CSharpProjectFileExtensionString);

        #endregion


        private CSharpProjectFileExtension(string value)
            : base(value)
        {
        }
    }
}
