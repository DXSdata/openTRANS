using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public partial class OrderInfo
    {
        [XmlElement("ORDER_ID")]
        public string OrderId;

        [XmlElement("ORDER_DATE")]
        public DateTime OrderDate;

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate = new DeliveryDate();

        [XmlElement("LANGUAGE")]
        public Language Language { get; set; }

        [XmlElement("MIME_ROOT")]
        public string MimeRoot { get; set; }

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties = new List<Party>();

        [XmlElement("CUSTOMER_ORDER_REFERENCE")]
        public CustomerOrderReference CustomerOrderReference = new CustomerOrderReference();

        [XmlElement("ORDER_PARTIES_REFERENCE")]
        public OrderPartiesReference OrderPartiesReference = new OrderPartiesReference();

        [XmlElement("DOCEXCHANGE_PARTIES_REFERENCE")]
        public DocExchangePartiesReference DocExchangePartiesReference { get; set; }

        [XmlElement("CURRENCY", Namespace = Namespace.bmecat)]
        public string Currency;

        [XmlElement("PAYMENT")]
        public Payment Payment { get; set; }

        [XmlElement("TERMS_AND_CONDITIONS")]
        public string TermsAndConditions { get; set; }

        [XmlElement("PARTIAL_SHIPMENT_ALLOWED")]
        public bool? PartialShipmentAllowed;

        [XmlElement("TRANSPORT")]
        public Transport Transport { get; set; }

        [XmlElement("INTERNATIONAL_RESTRICTIONS")]
        public TypedItem InternationalRestrictions { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        //will be serialized as array without a "remarks" parent
        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks = new List<TypedItem>();
    }
}
