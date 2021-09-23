using System.Linq;
using System.Xml.Serialization;

namespace openTRANS {
    public class QuotationSummary {
        public QuotationSummary() {

        }
        public QuotationSummary(Quotation quotation) {
            TotalItemNum = quotation.QuotationItemList.Count;
            TotalAmount = quotation.QuotationItemList.Sum(qi => qi.PriceLineAmount);
        }

        [XmlElement("TOTAL_ITEM_NUM")]
        public decimal TotalItemNum { get; set; }

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount { get; set; }
    }
}