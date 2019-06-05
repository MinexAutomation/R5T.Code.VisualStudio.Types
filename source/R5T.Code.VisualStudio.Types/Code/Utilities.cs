using System;
using System.Xml;

using R5T.NetStandard;
using R5T.Code.VisualStudio.IO;


namespace R5T.Code.VisualStudio
{
    public static class Utilities
    {
        /// <summary>
        /// Determines if a project-file has a version property.
        /// Returns true and the version if so, false and <see cref="VersionHelper.None"/> if not.
        /// </summary>
        public static bool HasVersion(ProjectFilePath projectFilePath, out Version version)
        {
            // Read the project file path in as XML.
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(projectFilePath.Value);

            // Determine if there is a Project/PropertyGroup/Version node.
            var versionNodeXPath = "//Project/PropertyGroup/Version";
            var versionNode = xmlDoc.SelectSingleNode(versionNodeXPath);

            var hasVersion = versionNode != null;
            if (hasVersion)
            {
                version = Version.Parse(versionNode.InnerText);
            }
            else
            {
                version = VersionHelper.None;
            }

            return hasVersion;
        }

        /// <summary>
        /// Gets the version for a project file.
        /// If no version is present, returns <see cref="VersionHelper.None"/>.
        /// </summary>
        public static Version GetVersion(ProjectFilePath projectFilePath)
        {
            // Read the project file path in as XML.
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(projectFilePath.Value);

            // Determine if there is a Project/PropertyGroup/Version node.
            var versionNodeXPath = "//Project/PropertyGroup/Version";
            var versionNode = xmlDoc.SelectSingleNode(versionNodeXPath);

            var hasVersion = versionNode != null;
            if (hasVersion)
            {
                var version = Version.Parse(versionNode.InnerText);
                return version;
            }
            else
            {
                return VersionHelper.None;
            }
        }

        public static void SetVersion(ProjectFilePath projectFilePath, Version version)
        {
            var versionString = version.ToString();

            // Read the project file path in as XML.
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(projectFilePath.Value);

            // Determine if there is a Project/PropertyGroup/Version node.
            var versionNodeXPath = "//Project/PropertyGroup/Version";
            var versionNode = xmlDoc.SelectSingleNode(versionNodeXPath);

            var hasVersion = versionNode != null;
            if (!hasVersion)
            {
                var propertyGroupXPath = "//Project/PropertyGroup";
                var propertyGroupNode = xmlDoc.SelectSingleNode(propertyGroupXPath);

                versionNode = xmlDoc.CreateElement("Version");
                propertyGroupNode.AppendChild(versionNode);
            }

            versionNode.InnerText = versionString;

            xmlDoc.Save(projectFilePath.Value);
        }
    }
}
