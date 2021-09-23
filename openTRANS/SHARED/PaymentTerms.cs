using System;
using System.Xml.Serialization;

namespace openTRANS {
    public class PaymentTerms {
        [XmlElement("PAYMENT_TERMS")]
        public string PaymentTerm { get; set; }

        [XmlElement("TIME_FOR_PAYMENT")]
        public TimeForPayment TimeForPayment { get; set; }

        [XmlElement("VALUE_DATE")]
        public DateTime ValueDate { get; set; }
    }
}