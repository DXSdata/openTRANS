using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

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

    public partial class OrderResponseSummary {
        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum;

        [XmlElement("TOTAL_AMOUNT")]
        public decimal TotalAmount;

        [XmlArray("ALLOW_OR_CHARGES_FIX")]
        [XmlArrayItem("ALLOW_OR_CHARGE")]
        public List<AllowOrCharge> AllowOrChargesFix = new List<AllowOrCharge>();

    }

    public partial class OrderResponseInfo {
        [XmlElement("ORDER_ID")]
        public string OrderId;

        [XmlElement("ORDERRESPONSE_DATE")]
        public DateTime OrderResponseDate;

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate;

        [XmlElement("SUPPLIER_ORDER_ID")]
        public string SupplierOrderId;

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate = new DeliveryDate();

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties = new List<Party>();

        [XmlElement("ORDER_PARTIES_REFERENCE")]
        public OrderPartiesReference OrderPartiesReference = new OrderPartiesReference();
    }

    public partial class OrderResponseItem {
        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("PRODUCT_ID")]
        public ProductId ProductId = new ProductId();

        [XmlElement("QUANTITY")]
        public int Quantity;

        [XmlElement("ORDER_UNIT", Namespace = Common.Namespace.bmecat)]
        public string OrderUnit;

        [XmlElement("PRODUCT_PRICE_FIX")]
        public ProductPriceFix ProductPriceFix = new ProductPriceFix();

        [XmlElement("PRICE_LINE_AMOUNT")]
        public decimal PriceLineAmount;

        [XmlElement("REMARKS")]
        public Remarks Remarks = new Remarks();
    }

    public partial class Remarks {
        [XmlText]
        public string Value;

        [XmlAttribute("type")]
        public string Type;
    }

    public partial class OrderResponseHeader {
        [XmlElement("ORDERRESPONSE_INFO")]
        public OrderResponseInfo OrderResponseInfo = new OrderResponseInfo();
    }
}