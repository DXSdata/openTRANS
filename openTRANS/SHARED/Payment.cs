using System.Xml.Serialization;

namespace openTRANS {
    public class Payment {
        [XmlElement("CARD")]
        public Card Card { get; set; }

        [XmlElement("ACCOUNT")]
        public Account Account { get; set; }

        [XmlElement("DEBIT")]
        public bool Debit { get; set; }

        [XmlElement("CHECK")]
        public bool Check { get; set; }

        [XmlElement("CASH")]
        public bool Cash { get; set; }

        [XmlElement("CENTRAL_REGULATIONS")]
        public bool CentralRegulations { get; set; } = false;
       
        [XmlElement("PAYMENT_TERMS")]
        public PaymentTerms PaymentTerms { get; set; }
    }
}