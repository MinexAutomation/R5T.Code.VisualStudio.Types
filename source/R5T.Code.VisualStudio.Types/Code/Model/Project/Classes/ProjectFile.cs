using System;
using System.Xml;


namespace R5T.Code.VisualStudio
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Built around an in-memory <see cref="System.Xml.XmlDocument"/> and allows using XML-related functions on the XML document project file content.
    /// </remarks>
    public class ProjectFile
    {
        #region Static

        public ProjectFile NewEmpty()
        {
            var emptyXmlDocument = new XmlDocument();

            var projectFileModel = new ProjectFile(emptyXmlDocument);
            return projectFileModel;
        }



        #endregion


        public XmlDocument XmlDocument { get; }


        private ProjectFile(XmlDocument xmlDocument)
        {
            this.XmlDocument = xmlDocument;
        }
    }
}
