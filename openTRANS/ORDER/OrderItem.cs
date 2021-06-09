using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class OrderItem
    {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ProductId();

        [XmlArray("PRODUCT_FEATURES")]
        [XmlArrayItem("FEATURE")]
        public List<Feature> ProductFeatures = new List<Feature>();

        [XmlElement("QUANTITY")]
        public decimal Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Common.Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ProductPriceFix();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount
        {
            get
            {
                return Quantity * ProductPriceFix.PriceAmount;
            }
            set { /* required for xml serialization */ }
        }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new List<TypedItem>();
    }
}
