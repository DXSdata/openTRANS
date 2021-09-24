using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class MeansOfTransport {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("MEANS_OF_TRANSPORT_ID", Namespace = Namespace.bmecat)]
        public string MeansOfTransportId { get; set; }

        [XmlElement("MEANS_OF_TRANSPORT_NAME", Namespace = Namespace.bmecat)]
        public string MeansOfTransportName { get; set; }
    }
}