using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS
{
    [XmlRoot("ORDERRESPONSE", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public partial class Orderresponse
    {
        [XmlAttribute("version")]
        public string Version = "2.1";

        [XmlElement("ORDERRESPONSE_HEADER")]
        public OrderresponseHeader OrderresponseHeader = new OrderresponseHeader();

        [XmlArray("ORDERRESPONSE_ITEM_LIST")]
        [XmlArrayItem("ORDERRESPONSE_ITEM")]
        public List<OrderresponseItem> OrderresponseItemList = new List<OrderresponseItem>();

        [XmlElement("ORDERRESPONSE_SUMMARY")]
        public OrderresponseSummary OrderresponseSummary
        {
            get
            {
                return new OrderresponseSummary(this);
            }
            set { }
        }
    }
}