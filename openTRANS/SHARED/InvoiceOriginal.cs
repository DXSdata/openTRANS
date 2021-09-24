using System.Xml.Serialization;

namespace openTRANS {
    public class InvoiceOriginal {
        [XmlElement("MIME")]
        public Mime Mime { get; set; }
    }
}