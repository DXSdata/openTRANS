using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
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
        public decimal Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Common.Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ProductPriceFix();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount;

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new List<TypedItem>();
    }
}