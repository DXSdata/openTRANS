using System;
using System.Xml.Serialization;

namespace openTRANS {
    public class TimeForPayment {
        [XmlElement("PAYMENT_DATE")]
        public DateTime PaymentDate { get; set; }

        [XmlElement("DAYS")]
        public int Days { get; set; }

        [XmlElement("DISCOUNT_FACTOR")]
        public double DiscountFactor { get; set; }

        [XmlElement("ALLOW_OR_CHARGES_FIX")]
        public AllowOrChargesFix AllowOrChargesFix { get; set; }
    }
}