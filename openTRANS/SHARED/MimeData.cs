using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class MimeData
    {
        [XmlText]
        public string Base64;

        [XmlAttribute("contentType")]
        public string ContentType;
    }
}