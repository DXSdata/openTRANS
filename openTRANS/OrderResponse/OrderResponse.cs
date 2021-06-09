using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    [XmlRoot("ORDERRESPONSE", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public partial class OrderResponse {

        [XmlElement("ORDERRESPONSE_HEADER")]
        public OrderResponseHeader OrderResponseHeader = new OrderResponseHeader();

        [XmlArray("ORDERRESPONSE_ITEM_LIST")]
        [XmlArrayItem("ORDERRESPONSE_ITEM")]
        public List<OrderResponseItem> OrderResponseItemList = new List<OrderResponseItem>();

        [XmlElement("ORDERRESPONSE_SUMMARY")]
        public OrderResponseSummary OrderResponseSummary = new OrderResponseSummary();
    }
}