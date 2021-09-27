using System.Linq;
using System.Xml.Serialization;

namespace openTRANS
{
    public partial class OrderresponseSummary
    {
        public OrderresponseSummary()
        {

        }
        public OrderresponseSummary(Orderresponse or)
        {
            TotalItemNum = or.OrderresponseItemList.Count;
            TotalAmount = or.OrderresponseItemList.Sum(item => item.PriceLineAmount);
        }

        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum;

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount;

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix = new AllowOrChargesFix();
    }
}