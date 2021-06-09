using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public partial class OrderResponseSummary {
        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum;

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount;

        [XmlArray("ALLOW_OR_CHARGES_FIX")]
        [XmlArrayItem("ALLOW_OR_CHARGE")]
        public List<AllowOrCharge> AllowOrChargesFix = new List<AllowOrCharge>();

    }
}