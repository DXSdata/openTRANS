using System.Xml.Serialization;

namespace openTRANS
{
    public partial class OrderresponseHeader
    {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo;

        [XmlElement("ORDERRESPONSE_INFO")]
        public OrderresponseInfo OrderresponseInfo = new OrderresponseInfo();
    }
}