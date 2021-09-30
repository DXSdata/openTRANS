using System.Xml.Serialization;

namespace openTRANS {
    public class VerificationAttachment {
        [XmlElement("MIME")]
        public Mime Mine { get; set; }
    }
}