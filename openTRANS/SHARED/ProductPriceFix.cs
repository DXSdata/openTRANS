using System;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class ProductPriceFix
    {
        [XmlElement("PRICE_AMOUNT", Namespace = Namespace.bmecat)]
        public decimal PriceAmount;

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix = new ();

        [XmlElement("PRICE_FLAG", Namespace = Namespace.bmecat)]
        public TypedItem PriceFlag = new ();

        [XmlElement("TAX_DETAILS_FIX", Namespace = Namespace.bmecat)]
        public TaxDetailsFix TaxDetailsFix = new ();

        /// <summary>
        /// Defines which number of items is included in the given price.
        /// Defaults to 1.
        /// See documentation for further details.
        /// </summary>
        [XmlElement("PRICE_QUANTITY", Namespace = Namespace.bmecat)]
        public decimal PriceQuantity = 1;

        [XmlElement("PRICE_BASE_FIX")]
        public PriceBaseFix PriceBaseFix = new ();
    }
}
