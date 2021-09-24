using System.Xml.Serialization;

namespace openTRANS {
    public class XmlSignature {
        [XmlElement("SIGNATURE")]
        public Signature Signature { get; set; }
    }
}