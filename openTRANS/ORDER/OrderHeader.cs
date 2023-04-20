using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class OrderHeader
    {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo = new ();

        [XmlElement("ORDER_INFO")]
        public OrderInfo OrderInfo = new ();

        [XmlElement("SOURCING_INFO")]
        public SourcingInfo SourcingInfo = new ();
    }
}
