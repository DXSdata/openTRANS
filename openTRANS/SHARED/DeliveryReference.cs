using System;
using System.Xml.Serialization;

namespace openTRANS {
    public class DeliveryReference {
        [XmlElement("DELIVERYNOTE_ID")]
        public string DeliverynoteId { get; set; }

        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId { get; set; }
        
        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }

        [XmlElement("DELIVERY_IDREF")]
        public string DeliveryIdref { get; set; }
    }
}