using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public partial class OrderResponseInfo
    {
        [XmlElement("ORDER_ID")]
        public string OrderId;

        [XmlElement("ORDERRESPONSE_DATE")]
        public DateTime OrderResponseDate;

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate;

        [XmlElement("ALT_CUSTOMER_ORDER_ID")]
        public List<string> AltCustomerOrderId;

        [XmlElement("SUPPLIER_ORDER_ID")]
        public string SupplierOrderId;

        [XmlElement("ORDERCHANGE_SEQUENCE_ID")]
        public uint OrderchangeSequenceId;

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate;

        [XmlElement("LANGUAGE", Namespace = Namespace.bmecat)]
        public Language Language;

        [XmlElement("MIME_ROOT", Namespace = Namespace.bmecat)]
        public string MimeRoot;

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties = new List<Party>();

        [XmlElement("ORDER_PARTIES_REFERENCE")]
        public OrderPartiesReference OrderPartiesReference = new OrderPartiesReference();

        [XmlElement("DOCEXCHANGE_PARTIES_REFERENCE")]
        public DocExchangePartiesReference DocexchangePartiesReference;

        [XmlElement("CURRENCY", Namespace = Namespace.bmecat)]
        public string Currency;

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo;

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks;
    }
}