using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Code.VisualStudio.IO
{
    public class SolutionFileExtension : FileExtension
    {
        #region Static

        /// <summary>
        /// The <see cref="Constants.SolutionFileExtension"/> value.
        /// </summary>
        public static readonly SolutionFileExtension Instance = new SolutionFileExtension(Constants.SolutionFileExtension);

        #endregion


        public SolutionFileExtension(string value)
            : base(value)
        {
        }
    }
}
