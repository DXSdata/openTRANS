using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class QuotationItem {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId { get; set; }

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId { get; set; }

        [XmlElement("PRODUCT_FEATURES")]
        public ProductFeatures ProductFeatures { get; set; }

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents { get; set; }

        [XmlElement("QUANTITIY")]
        public decimal Quantity { get; set; }

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix { get; set; }

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount { get; set; }

        [XmlElement("AGREEMENT")]
        public Agreement Agreement { get; set; }

        [XmlElement("CATALOG_REFERENCE")]
        public CatalogReference CatalogReference { get; set; }

        [XmlElement("PARTIAL_SHIPMENT")]
        public bool PartialShipment { get; set; }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }

        [XmlArray("PARTIAL_DELIVERY_LIST")]
        [XmlArrayItem("PARTIAL_DELIVERY")]
        public List<PartialDelivery> PartialDeliveryList { get; set; }

        [XmlElement("SHIPMENT_PARTIES_REFERENCE")]
        public ShipmentPartiesReference ShipmentPartiesReference { get; set; }

        [XmlElement("TRANSPORT", Namespace = Namespace.bmecat)]
        public Transport Transport { get; set; }

        [XmlElement("INTERNATIONAL_RESTRICTIONS", Namespace = Namespace.bmecat)]
        public InternationalRestrictions InternationalRestrictions { get; set; }

        [XmlElement("SPECIAL_TREATMENT_CLASS", Namespace = Namespace.bmecat)]
        public SpecialTreatmentClass SpecialTreatmentClass { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks { get; set; }
    }
}