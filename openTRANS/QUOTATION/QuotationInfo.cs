using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class QuotationInfo {
        [XmlElement("QUOTATION_ID")]
        public string QoutationId { get; set; }

        [XmlElement("QUOTATION_DATE")]
        public DateTime QuotationDate { get; set; }

        [XmlElement("VALID_START_DATE")]
        public DateTime ValidStartDate { get; set; }

        [XmlElement("VALID_END_DATE")]
        public DateTime ValidEndDate { get; set; }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }

        [XmlElement("LANGUAGE")]
        public Language Language { get; set; }

        [XmlElement("MIME_ROOT")]
        public string MimeRoot { get; set; }

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties { get; set; }

        [XmlElement("ORDER_PARTIES_REFERENCE")]
        public OrderPartiesReference OrderPartiesReference { get; set; }

        [XmlElement("DOCEXCHANGE_PARTIES_REFERENCE")]
        public DocExchangePartiesReference DocExchangePartiesReference { get; set; }

        [XmlElement("AGREEMENT")]
        public Agreement Agreement { get; set; }

        [XmlElement("CATALOG_REFERENCE")]
        public CatalogReference CatalogReference { get; set; }

        [XmlElement("CURRENCY")]
        public string Currency { get; set; } = Currencies.EUR;

        [XmlElement("PAYMENT")]
        public Payment Payment { get; set; }

        [XmlElement("")]
        public string TermsAndConditions { get; set; }

        [XmlElement("TRANSPORT")]
        public Transport Transport { get; set; }

        [XmlElement("INTERNATIONAL_RESTRICTIONS")]
        public InternationalRestrictions InternationalRestrictions { get; set; }

        [XmlElement("TERRITORY")]
        public string Territory { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks { get; set; }
    }
}