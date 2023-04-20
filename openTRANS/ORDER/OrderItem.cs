using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class OrderItem
    {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ();

        [XmlArray("PRODUCT_FEATURES")]
        [XmlArrayItem("FEATURE")]
        public List<Feature> ProductFeatures = new ();

        [XmlElement("QUANTITY")]
        public decimal Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount
        {
            get => Quantity * ProductPriceFix.PriceAmount;
            set { /* required for xml serialization */ }
        }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new ();

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate = new ();

    }
}
