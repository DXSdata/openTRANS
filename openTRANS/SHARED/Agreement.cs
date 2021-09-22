using System.Xml.Serialization;

namespace openTRANS {
    public partial class Agreement
    {
        [XmlElement("AGREEMENT_ID")]
        public string AgreementId;
    }
}
