using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class DeliveryDate
    {
        [XmlAttribute("type")]
        public string Type;

        [XmlElement("DELIVERY_START_DATE")]
        public DateTime DeliveryStartDate;

        [XmlElement("DELIVERY_END_DATE")]
        public DateTime DeliveryEndDate;
    }
}
