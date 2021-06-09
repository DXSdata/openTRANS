using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class ShipmentPartiesReference
    {
        [XmlElement("DELIVERY_IDREF")]
        public TypedItem DeliveryIdRef = new TypedItem();
    }
}
