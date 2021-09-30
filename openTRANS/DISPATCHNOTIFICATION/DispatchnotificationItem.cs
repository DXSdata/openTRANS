using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class DispatchnotificationItem {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId { get; set; }

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId { get; set; }

        [XmlElement("PRODUCT_FEATURES")]
        public ProductFeatures ProductFeatures { get; set; }

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents { get; set; }

        [XmlElement("QUANTITY")]
        public decimal Quantity { get; set; }

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit { get; set; }

        [XmlElement("PARTIAL_DELIVERY_LIST")]
        public List<PartialDelivery> PartialDeliveryList { get; set; }

        [XmlElement("DELIVERY_COMPLETED")]
        public bool DeliveryCompleted { get; set; }

        [XmlElement("DELIVERY_REFERNCE")]
        public DeliveryReference DeliveryReference { get; set; }

        [XmlElement("SUPPLIER_IDREF", Namespace = Namespace.bmecat)]
        public TypedItem SupplierIdref { get; set; }

        [XmlElement("ORDER_REFERENCE")]
        public OrderReference OrderReference { get; set; }

        [XmlElement("SUPPLIER_ORDER_REFERENCE")]
        public SupplierOrderReference SupplierOrderReference { get; set; }

        [XmlElement("CUSTOMER_ORDER_REFERENCE")]
        public CustomerOrderReference CustomerOrderReference { get; set; }

        [XmlElement("SHIPMENT_PARTIES_REFERENCE")]
        public ShipmentPartiesReference ShipmentPartiesReference { get; set; }

        [XmlElement("LOGISTIC_DETAILS")]
        public LogisticDetails LogisticDetails { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks { get; set; }
    }
}