using System;
using System.Linq;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class OrderResponseSummary
    {
        public OrderResponseSummary()
        {

        }
        public OrderResponseSummary(OrderResponse or)
        {
            TotalItemNum = or.OrderResponseItemList.Count;
            TotalAmount = or.OrderResponseItemList.Sum(item => item.PriceLineAmount);
        }

        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum;

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount;

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix = new ();
    }
}