using System.Xml.Serialization;

namespace openTRANS
{
    public partial class OrderResponseHeader
    {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo;

        [XmlElement("ORDERRESPONSE_INFO")]
        public OrderResponseInfo OrderResponseInfo = new OrderResponseInfo();
    }
}