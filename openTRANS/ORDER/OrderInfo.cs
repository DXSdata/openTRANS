using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class OrderInfo
    {
        [XmlElement("ORDER_ID")]
        public string OrderId;

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate;

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate = new ();

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties = new List<Party>();

        [XmlElement("ORDER_PARTIES_REFERENCE")]
        public OrderPartiesReference OrderPartiesReference = new ();

        [XmlElement("CUSTOMER_ORDER_REFERENCE")]
        public CustomerOrderReference CustomerOrderReference = new ();

        //will be serialized as array without a "remarks" parent
        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new ();

        [XmlElement("CURRENCY", Namespace = Namespace.bmecat)]
        public string Currency;

        [XmlElement("PARTIAL_SHIPMENT_ALLOWED")]
        public bool? PartialShipmentAllowed;
    }
}
