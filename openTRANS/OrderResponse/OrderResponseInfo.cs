using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public partial class OrderResponseInfo {
        [XmlElement("ORDER_ID")]
        public string OrderId;

        [XmlElement("ORDERRESPONSE_DATE")]
        public DateTime OrderResponseDate;

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate;

        [XmlElement("SUPPLIER_ORDER_ID")]
        public string SupplierOrderId;

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate = new DeliveryDate();

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties = new List<Party>();

        [XmlElement("ORDER_PARTIES_REFERENCE")]
        public OrderPartiesReference OrderPartiesReference = new OrderPartiesReference();
    }
}