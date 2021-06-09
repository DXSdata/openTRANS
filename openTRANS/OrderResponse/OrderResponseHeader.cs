using System.Xml.Serialization;

namespace openTRANS {
    public partial class OrderResponseHeader {
        [XmlElement("ORDERRESPONSE_INFO")]
        public OrderResponseInfo OrderResponseInfo = new OrderResponseInfo();
    }
}