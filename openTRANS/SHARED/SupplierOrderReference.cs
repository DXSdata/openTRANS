using System.Xml.Serialization;

namespace openTRANS {
    public class SupplierOrderReference {
        [XmlElement("SUPPLIER_ORDER_ID")]
        public string SupplierOrderId { get; set; }

        [XmlElement("SUPPLIER_ORDER_ITEM_ID")]
        public string SupplierOrderItemId { get; set; }
    }
}