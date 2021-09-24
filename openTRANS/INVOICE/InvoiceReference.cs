using System;
using System.Xml.Serialization;

namespace openTRANS {
    public class InvoiceReference {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("INVOICE_ID")]
        public string InvoiceId { get; set; }

        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId { get; set; }

        [XmlElement("INVOICE_DATE")]
        public DateTime InvoiceDate { get; set; }

        [XmlElement("POST_DATE")]
        public DateTime PostDate { get; set; }

        [XmlElement("REASON_FOR_TRANSPORT")]
        public string ReasonForTransport { get; set; }

        [XmlElement("INVOICE_DESCR")]
        public string InvoiceDescr { get; set; }
    }
}