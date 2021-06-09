using System.Xml.Serialization;

namespace openTRANS {
    public partial class ProductPriceFix
    {
        [XmlElement("PRICE_AMOUNT", Namespace = Common.Namespace.bmecat)]
        public decimal PriceAmount;

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix = new AllowOrChargesFix();

        /// <summary>
        /// Defines which number of items is included in the given price.
        /// Defaults to 1.
        /// See documentation for further details.
        /// </summary>
        [XmlElement("PRICE_QUANTITY", Namespace = Common.Namespace.bmecat)]
        public decimal PriceQuantity = 1;
    }
}
