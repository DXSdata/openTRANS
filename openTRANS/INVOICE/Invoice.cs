using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace openTRANS {
    [XmlRoot("INVOICE", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public class Invoice {
        [XmlElement("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "http://www.opentrans.org/XMLSchema/2.1%20opentrans_2_1.xsd";

        [XmlAttribute("version")]
        public const string Version = "2.1";

        [XmlElement("INVOICE_HEADER", Namespace = XmlSchema.InstanceNamespace)]
        public InvoiceHeader InvoiceHeader { get; set; }

        [XmlArray("INVOICE_ITEM_LIST")]
        [XmlArrayItem("INVOICE_ITEM")]
        public List<InvoiceItem> InvoiceItemList { get; set; }

        [XmlElement("INVOICE_SUMMARY")]
        public InvoiceSummary InvoiceSummary {
            get => new InvoiceSummary(this);
            set { }
        }

    }
}
