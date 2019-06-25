using System;
using System.Xml;


namespace R5T.Code.VisualStudio
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Built around an in-memory <see cref="XmlDocument"/> and allows using XML-related functions on the XML document project file content.
    /// </remarks>
    public class ProjectFileModel
    {
        #region Static



        #endregion


        public XmlDocument XmlDocument { get; }


        private ProjectFileModel(XmlDocument xmlDocument)
        {
            this.XmlDocument = xmlDocument;
        }
    }
}
