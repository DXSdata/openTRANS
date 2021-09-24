using System.Xml.Serialization;

namespace openTRANS {
    public class EBilling {
        [XmlElement("INVOICE_ORIGINAL")]
        public InvoiceOriginal InvoiceOriginal { get; set; }

        [XmlElement("SIGNATURE_AND_VERIFICATION")]
        public SignatureAndVerification SignatureAndVerification { get; set; }
    }
}