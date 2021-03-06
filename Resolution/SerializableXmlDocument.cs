// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializableXmlDocument.cs" company="Solidsoft Reply Ltd.">
//   Copyright 2015 Solidsoft Reply Limited.
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SolidsoftReply.Esb.Libraries.Resolution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;
    using System.Security.Permissions;
    using System.Xml;

    /// <summary>
    /// Serializable XmlDocument class, derived from XmlDocument.
    /// </summary>
    [Serializable]
    public sealed class SerializableXmlDocument : XmlDocument, ISerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableXmlDocument"/> class.
        /// </summary>
        public SerializableXmlDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableXmlDocument"/> class.
        /// </summary>
        /// <param name="nt">
        /// The XML name table.
        /// </param>
        public SerializableXmlDocument(XmlNameTable nt)
            : base(nt)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableXmlDocument"/> class.
        /// </summary>
        /// <param name="xmlDoc">
        /// The XML document.
        /// </param>
        public SerializableXmlDocument(XmlNode xmlDoc)
        {
            if (xmlDoc.OuterXml.Length > 0)
            {
                this.LoadXml(xmlDoc.OuterXml);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableXmlDocument"/> class.
        /// </summary>
        /// <param name="imp">
        /// The imp.
        /// </param>
        internal SerializableXmlDocument(XmlImplementation imp)
            : base(imp)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableXmlDocument"/> class. 
        /// Used during deserialization.  For use with BinaryFormatter.
        /// </summary>
        /// <param name="info">
        /// Serialization Info
        /// </param>
        /// <param name="context">
        /// Streaming Context
        /// </param>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        private SerializableXmlDocument(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentException(string.Format("SerializableXmlDocument.  {0}", string.Format(Properties.Resources.ExceptionInfoNull, "constructor")));
            }

            var xmlText = (string)info.GetValue("xmlContent", typeof(string));

            if (!string.IsNullOrEmpty(xmlText))
            {
                this.LoadXml(xmlText);
            }
        }

        /// <summary>
        /// Serialise the XmlDocument.  For use with BinaryFormatter.
        /// </summary>
        /// <param name="info">Serialization Info</param>
        /// <param name="context">Streaming Context</param>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentException(string.Format("SerializableXmlDocument.  {0}", string.Format(Properties.Resources.ExceptionInfoNull, "GetObjectData")));
            }

            var xmlText = this.OuterXml;
            info.AddValue("xmlContent", xmlText);
        }
    }
}