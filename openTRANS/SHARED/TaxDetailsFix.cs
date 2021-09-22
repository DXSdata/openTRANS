using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class TaxDetailsFix {
        [XmlElement("CALCULATION_SEQUENCE", Namespace = Namespace.bmecat)]
        public uint CalculationSequence;

        [XmlElement("TAX_CATEGORY", Namespace = Namespace.bmecat)]
        public string TaxCategory;

        [XmlElement("TAX_TYPE", Namespace = Namespace.bmecat)]
        public string TaxType;

        [XmlElement("TAX", Namespace = Namespace.bmecat)]
        public decimal Tax;

        [XmlElement("TAX_AMOUNT", Namespace = Namespace.bmecat)]
        public decimal TaxAmount;

        [XmlElement("TAX_BASE", Namespace = Namespace.bmecat)]
        public decimal TaxBase;

        [XmlElement("EXEMPTION_REASON", Namespace = Namespace.bmecat)]
        public string ExemptionReason;

        [XmlElement("JURISDICTION", Namespace = Namespace.bmecat)]
        public string Jurisdiction;
    }
}