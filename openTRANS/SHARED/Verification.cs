using System.Xml.Serialization;

namespace openTRANS {
    public class Verification {
        [XmlElement("VERIFICATION_PARTY_IDREF")]
        public string VerificationPartyIdref { get; set; }

        [XmlElement("VERIFICATION_SUCCESS")]
        public bool VerificationSuccess { get; set; }

        [XmlElement("VERIFICATION_REPORT")]
        public VerificationReport VerificationReport { get; set; }
    }
}