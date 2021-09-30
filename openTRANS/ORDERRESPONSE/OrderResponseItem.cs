using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class OrderResponseItem
    {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ProductId();

        [XmlElement("PRODUCT_FEATURES")]
        public ProductFeatures ProductFeatures = new ProductFeatures();

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents = new ProductComponents();

        [XmlElement("QUANTITY")]
        public int Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ProductPriceFix();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount {
            get => Quantity * ProductPriceFix.PriceAmount;
            set { }
        }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }

        [XmlArray("PARTIAL_DELIVERY_LIST")]
        [XmlArrayItem("PARTIAL_DELIVERY")]
        public List<PartialDelivery> PartialDeliveryList { get; set; }

        [XmlElement("SHIPMENT_PARTIES_REFERENCE")]
        public ShipmentPartiesReference ShipmentPartiesReference { get; set; }

        [XmlElement("SPECIAL_TREATMENT_CLASS")]
        public string SpecialTreatmentClass { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new List<TypedItem>();
    }
}