using System.Linq;
using System.Xml.Serialization;

namespace openTRANS
{
    public partial class OrderSummary
    {
        public OrderSummary()
        {
        }

        public OrderSummary(Order o)
        {
            TotalItemNum = o.OrderItemList.Count;
            TotalAmount = o.OrderItemList.Sum(oi => oi.PriceLineAmount);
        }

        [XmlElement("TOTAL_ITEM_NUM")]
        public decimal TotalItemNum;

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount;
    }
}
