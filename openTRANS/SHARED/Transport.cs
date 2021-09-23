using System.Xml.Serialization;

namespace openTRANS {
    public class Transport {
        [XmlElement("INCOTERM")]
        public string Incoterm { get; set; }

        [XmlElement("LOCATION")]
        public string Location { get; set; }

        [XmlElement("TRANSPORT_REMARK")]
        public string TransportRemark { get; set; }
    }
}