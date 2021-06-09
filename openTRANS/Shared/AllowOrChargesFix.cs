using System.Xml.Serialization;

namespace openTRANS {
    public partial class AllowOrChargesFix
    {
        [XmlElement("ALLOW_OR_CHARGE")]
        public AllowOrCharge AllowOrCharge = new AllowOrCharge();

        [XmlElement("ALLOW_OR_CHARGES_TOTAL_AMOUNT")]
        public decimal AllowOrChargesTotalAmount;
    }
}
