using System.Xml.Serialization;

namespace openTRANS {
    public class VerificationReport {
        [XmlElement("VERIFICATION_ATTACHMENT")]
        public VerificationAttachment VerificationAttachment { get; set; }

        [XmlElement("VERIFICATION_PROTOCOL")]
        public VerificationProtocol VerificationProtocol { get; set; }

        [XmlElement("VERIFICATION_XMLREPORT")]
        public VerificationXmlReport VerificationXmlReport { get; set; }
    }
}