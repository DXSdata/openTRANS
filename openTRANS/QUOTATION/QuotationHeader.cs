using System.Xml.Serialization;

namespace openTRANS {
    public class QuotationHeader {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo { get; set; } = new ControlInfo();

        [XmlElement("QUOTATION_INFO")]
        public QuotationInfo QuotationInfo { get; set; }
    }
}