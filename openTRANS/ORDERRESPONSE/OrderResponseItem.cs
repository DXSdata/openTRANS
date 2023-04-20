using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class OrderResponseItem
    {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ();

        [XmlElement("PRODUCT_FEATURES")]
        public ProductFeatures ProductFeatures = new ();

        [XmlElement("PRODUCT_COMPONENTS")]
        public ProductComponents ProductComponents = new ();

        [XmlElement("QUANTITY")]
        public decimal Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount;

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new ();
    }
}