using System.Xml.Serialization;

namespace openTRANS {
    public class VerificationXmlReport {
        [XmlElement("XML_FORMAT")]
        public string XmlFormat { get; set; }

        [XmlElement("REPORT_UDX")]
        public UdxItem ReportUdx { get; set; }
    }
}