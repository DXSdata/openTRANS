using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public class PriceBaseFix
    {
        [XmlElement("PRICE_UNIT_VALUE")]
        public float PriceUnitValue;

        [XmlElement("PRICE_UNIT", Namespace = Namespace.bmecat)]
        public string PriceUnit;

        [XmlElement("PRICE_UNIT_FACTOR", Namespace = Namespace.bmecat)]
        public float PriceUnitFactor;
    }
}