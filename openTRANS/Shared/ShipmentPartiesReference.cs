using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class ShipmentPartiesReference
    {
        [XmlElement("DELIVERY_IDREF")]
        public TypedItem DeliveryIdRef = new TypedItem();

        [XmlElement("FINAL_DELIVERY_IDREF")]
        public TypedItem FinalDeliveryIdRef = new TypedItem();

        [XmlElement("DELIVERER_IDREF")]
        public TypedItem DelivererIdRef = new TypedItem();
    }
}
