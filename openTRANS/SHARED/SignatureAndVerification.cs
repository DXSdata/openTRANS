using System.Xml.Serialization;

namespace openTRANS {
    public class SignatureAndVerification {
        [XmlElement("SIGNATURE")]
        public Signature Signature { get; set; }

        [XmlElement("VERIFICATION")]
        public Verification Verification { get; set; }
    }
}