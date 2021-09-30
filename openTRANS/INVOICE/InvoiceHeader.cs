using System.Xml.Serialization;

namespace openTRANS {
    public class InvoiceHeader {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo { get; set; }

        [XmlElement("INVOICE_INFO")]
        public InvoiceInfo InvoiceInfo { get; set; }

        [XmlElement("ORDER_HISTROY")]
        public OrderHistory OrderHistory { get; set; }
    }
}