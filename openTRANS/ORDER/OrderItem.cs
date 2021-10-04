using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public partial class OrderItem
    {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ProductId();

        [XmlArray("PRODUCT_FEATURES")]
        [XmlArrayItem("FEATURE")]
        public List<Feature> ProductFeatures = new List<Feature>();

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents { get; set; }

        [XmlElement("QUANTITY")]
        public decimal Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ProductPriceFix();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount
        {
            get => Quantity * ProductPriceFix.PriceAmount;
            set { /* required for xml serialization */ }
        }

        [XmlElement("PARTIAL_SHIPMENT_ALLOWED")]
        public bool PartialShipmentAllowed { get; set; }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate = new DeliveryDate();

        [XmlArray("PARTIAL_DELIVERY_LIST")]
        [XmlArrayItem("PARTIAL_DELIVERY")]
        public List<PartialDelivery> PartialDeliveryList { get; set; }

        [XmlElement("SOURCING_INFO")]
        public SourcingInfo SourcingInfo { get; set; }

        [XmlElement("CUSTOM_ORDER_REFERENCE")]
        public CustomerOrderReference CustomerOrderReference { get; set; }

        [XmlElement("ACCOUNTING_INFO", Namespace = Namespace.bmecat)]
        public AccountingInfo AccountingInfo { get; set; }

        [XmlElement("SHIPMENT_PARTIES_REFERENCE")]
        public ShipmentPartiesReference ShipmentPartiesReference { get; set; }

        [XmlElement("TRANSPORT", Namespace = Namespace.bmecat)]
        public Transport Transport { get; set; }

        [XmlElement("INTERNATIONAL_RESTRICTIONS", Namespace = Namespace.bmecat)]
        public TypedItem InternationalRestriction { get; set; }

        [XmlElement("SPECIAL_TREATMENT_CLASS", Namespace = Namespace.bmecat)]
        public TypedItem SpecialTreatmentClass { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new List<TypedItem>();
    }
}
