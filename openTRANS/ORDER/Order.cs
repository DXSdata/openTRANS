using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [XmlRoot("ORDER", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public partial class Order
    {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "http://www.opentrans.org/XMLSchema/2.1%20opentrans_2_1.xsd";

        [XmlAttribute("version")]
        public const string Version = "2.1";

        [XmlAttribute("type")]
        public string Type = OrderType.Standard;

        [XmlElement("ORDER_HEADER")]
        public OrderHeader OrderHeader = new OrderHeader();

        [XmlArray("ORDER_ITEM_LIST")]
        [XmlArrayItem("ORDER_ITEM")]
        public List<OrderItem> OrderItemList = new List<OrderItem>();

        [XmlElement("ORDER_SUMMARY")]
        public OrderSummary OrderSummary
        {
            get
            {
                return new OrderSummary(this);
            }
            set { /* required for xml serialization */ }
        }
    }
}
