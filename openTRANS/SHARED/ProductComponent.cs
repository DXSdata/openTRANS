using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public class ProductComponent
    {
        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ProductId();

        [XmlElement("PRODUCT_FEATURES")]
        public ProductFeatures ProductFeatures = new ProductFeatures();

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents = new ProductComponents();

        [XmlElement("QUANTITY")]
        public decimal Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ProductPriceFix();
    }
}