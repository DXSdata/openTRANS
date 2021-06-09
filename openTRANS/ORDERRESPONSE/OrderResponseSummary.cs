using System.Xml.Serialization;

namespace openTRANS {
    public partial class OrderResponseSummary {
        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum;

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount;

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix = new AllowOrChargesFix();
    }
}