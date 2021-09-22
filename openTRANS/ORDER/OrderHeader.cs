using System.Xml.Serialization;

namespace openTRANS
{
    public partial class OrderHeader
    {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo = new ControlInfo();

        [XmlElement("ORDER_INFO")]
        public OrderInfo OrderInfo = new OrderInfo();

        [XmlElement("SOURCING_INFO")]
        public SourcingInfo SourcingInfo = new SourcingInfo();
    }
}
