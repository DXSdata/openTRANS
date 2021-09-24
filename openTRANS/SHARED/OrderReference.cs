using System;
using System.Xml.Serialization;

namespace openTRANS {
    public class OrderReference {
        [XmlElement("ORDER_ID")]
        public string OrderId { get; set; }

        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId { get; set; }

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate { get; set; }

        [XmlElement("ORDER_DESCR")]
        public string OrderDescr { get; set; }

        [XmlElement("AGREEMENT")]
        public Agreement Agreement { get; set; }

        [XmlElement("CATALOG_REFERENCE")]
        public CatalogReference CatalogReference { get; set; }
    }
}