using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class InvoiceItem {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId { get; set; }

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId { get; set; }

        [XmlArray("PRODUCT_FEATURES")]
        [XmlArrayItem("FEATURE")]
        public List<Feature> ProductFeatures { get; set; }

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents { get; set; }

        [XmlElement("QUANTITY")]
        public decimal Quantity { get; set; }

        [XmlElement("ORDER_UNIT")]
        public string OrderUnit { get; set; }

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix { get; set; }

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount { get; set; }

        [XmlElement("FOREIGN_CURRENCY")]
        public string ForeignCurrency { get; set; }

        [XmlElement("EXCHANGE_RATE")]
        public decimal ExchangeRate { get; set; }

        [XmlElement("INVOICE_CORRECTION")]
        public InvoiceCorrection InvoiceCorrection { get; set; }

        [XmlElement("ORDER_REFERENCE")]
        public OrderReference OrderReference { get; set; }

        [XmlElement("SUPPLIER_ORDER_REFERENCE")]
        public SupplierOrderReference SupplierOrderReference { get; set; }

        [XmlElement("CUSTOMER_ORDER_REFERENCE")]
        public CustomerOrderReference CustomerOrderReference { get; set; }

        [XmlElement("DELIVERY_REFERENCE")]
        public DeliveryReference DeliveryReference { get; set; }

        [XmlElement("LOGISTIC_DETAILS")]
        public LogisticDetails LogisticDetails { get; set; }

        [XmlElement("ACCOUNTING_INFO")]
        public AccountingInfo AccountingInfo { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks { get; set; }
    }
}