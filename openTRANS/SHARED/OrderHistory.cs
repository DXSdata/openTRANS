using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public class OrderHistory {
        [XmlElement("ORDER_ID")]
        public string OrderId { get; set; }

        [XmlElement("ALT_CUSTOMER_ORDER_ID")]
        public List<string> AltCustomerOrderId { get; set; }

        [XmlElement("SUPPLIER_ORDER_ID")]
        public string SupplierOrderId { get; set; }

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate { get; set; }

        [XmlElement("ORDER_DESCR")]
        public string OrderDescr { get; set; }

        [XmlElement("DELIVERYNOTE_ID")]
        public string DeliverynoteId { get; set; }

        [XmlElement("DELIVERYNOTE_DATE")]
        public DateTime DeliverynoteDate { get; set; }

        [XmlElement("AGREEMENT")]
        public Agreement Agreement { get; set; }

        [XmlElement("CATALOG_REFERENCE")]
        public CatalogReference CatalogReference { get; set; }
    }
}