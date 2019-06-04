using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public class CSharpProjectFileExtension : FileExtension
    {
        #region Static

        /// <summary>
        /// The <see cref="Constants.CSharpProjectFileExtension"/> value.
        /// </summary>
        public static readonly CSharpProjectFileExtension Instance = new CSharpProjectFileExtension(Constants.CSharpProjectFileExtension);

        #endregion


        public CSharpProjectFileExtension(string value)
            : base(value)
        {
        }
    }
}
