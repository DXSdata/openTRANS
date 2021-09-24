using System.Xml.Serialization;

namespace openTRANS {
    public class Signature {
        [XmlElement("MIME")]
        public Mime Mime { get; set; }

        [XmlElement("SIGNATURE_IN_ORIGINAL")]
        public bool SigatureInOriginal { get; set; }

        [XmlElement("XML_SIGNATURE")]
        public XmlSignature XmlSignature { get; set; }
    }
}