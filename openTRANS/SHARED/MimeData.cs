using System.Xml.Serialization;

namespace openTRANS {
    public class MimeData {
        [XmlText]
        public string Base64;

        [XmlAttribute("contentType")]
        public string ContentType;
    }
}