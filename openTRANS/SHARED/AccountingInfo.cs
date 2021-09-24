using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class AccountingInfo {
        [XmlElement("COST_CATEGORY_ID")]
        public TypedItem CostCategoryId { get; set; }

        [XmlElement("COST_TYPE")]
        public string CostType { get; set; }

        [XmlElement("COST_ACCOUNT")]
        public string CostAccount { get; set; }

    }
}