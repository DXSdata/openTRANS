using System.Linq;
using System.Xml.Serialization;

namespace openTRANS {
    public class InvoiceSummary {
        public InvoiceSummary() {

        }
        public InvoiceSummary(Invoice invoice) {
            TotalItemNum = invoice.InvoiceItemList.Count;
            TotalAmount = invoice.InvoiceItemList.Sum(ii => ii.PriceLineAmount);
        }

        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum { get; set; }

        [XmlElement("NET_VALUE_GOODS")]
        public decimal NetValueGoods { get; set; }

        [XmlElement("NET_VALUE_EXTRA")]
        public decimal NetValueExtra { get; set; }

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount { get; set; }

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix { get; set; }

        [XmlElement("TOTAL_TAX")]
        public TotalTax TotalTax { get; set; }

    }
}