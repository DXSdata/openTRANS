using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class AllowOrChargeValue
    {
        [XmlElement("AOC_PERCENTAGE_FACTOR")]
        public decimal AocPercentageFactor;

        [XmlElement("AOC_MONETARY_AMOUNT")]
        public decimal AocMonetaryAmount;

        [XmlElement("AOC_ORDER_UNITS_COUNT")]
        public AocOrderUnitsCount AocOrderUnitsCount = new ();

        [XmlElement("AOC_ADDITIONAL_ITEMS")]
        public string AocAdditionalItems;

    }
}
