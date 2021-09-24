using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class InvoiceInfo {
        [XmlElement("INVOICE_ID")]
        public string InvoiceId { get; set; }

        [XmlElement("INVOICE_DATE")]
        public DateTime InvoiceDate { get; set; }

        [XmlElement("REASON_FOR_TRANSFER")]
        public string ReasonForTransfer { get; set; }

        [XmlElement("INVOICE_TYPE")]
        public string InvoiceType { get; set; } = Common.InvoiceType.Invoice;

        [XmlElement("INVOICE_COVERAGE")]
        public string InvoiceCoverage { get; set; } = InvoiceCoverageType.Single;

        [XmlElement("DELIVERYNOTE_ID")]
        public string DeliverynoteId { get; set; }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }

        [XmlElement("DELIVERY_IDREF")]
        public TypedItem DeliveryIdref { get; set; }

        [XmlElement("LANGUAGE", Namespace = Namespace.bmecat, IsNullable = false)]
        public Language Language { get; set; }

        [XmlElement("MIME_ROOT", Namespace = Namespace.bmecat, IsNullable = false)]
        public string MimeRoot { get; set; }

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties { get; set; }

        [XmlElement("INVOICE_ISSUER_IDREF")]
        public TypedItem InvoiceIssuerIdref { get; set; }

        [XmlElement("INVOICE_RECIPIENT_IDREF")]
        public TypedItem InvoiceRecipientIdref { get; set; }

        [XmlElement("BUYER_IDREF", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem BuyerIdref { get; set; }

        [XmlElement("SUPPLIER_IDREF", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem SupplierIdref { get; set; }

        [XmlElement("PAYER_IDREF")]
        public TypedItem Payer_Idref { get; set; }

        [XmlElement("REMITTEE_IDREF")]
        public TypedItem RemitteeIdref { get; set; }

        [XmlElement("DOCEXCHANGE_PARTIES_REFERENCE")]
        public DocExchangePartiesReference DocExchangePartiesReference { get; set; }

        [XmlElement("CURRNECY", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Currency { get; set; }

        [XmlElement("PAYMENT")]
        public Payment Payment { get; set; }

        [XmlElement("TERMS_AND_CONDITIONS")]
        public string TermsAndConditions { get; set; }

        [XmlElement("ACCOUNTING_INFO", Namespace = Namespace.bmecat, IsNullable = false)]
        public AccountingInfo AccountingInfo { get; set; }

        [XmlElement("E_BILLING")]
        public EBilling EBilling { get; set; }

        [XmlElement("LOGISTIC_DETAILS_INFO")]
        public LogisticDetailsInfo LogisticDetailsInfo { get; set; }

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks { get; set; }
    }
}