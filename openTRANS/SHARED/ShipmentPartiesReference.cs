using System;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class ShipmentPartiesReference
    {
        [XmlElement("DELIVERY_IDREF")]
        public TypedItem DeliveryIdRef = new ();

        [XmlElement("FINAL_DELIVERY_IDREF")]
        public TypedItem FinalDeliveryIdRef = new ();

        [XmlElement("DELIVERER_IDREF")]
        public TypedItem DelivererIdRef = new ();
    }
}
