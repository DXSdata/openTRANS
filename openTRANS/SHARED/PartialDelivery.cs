using System.Xml.Serialization;

namespace openTRANS {
    public class PartialDelivery {
        [XmlElement("QUANTITY")]
        public decimal Quantity { get; set; }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }
    }
}