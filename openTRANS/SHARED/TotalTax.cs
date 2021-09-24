using System.Xml.Serialization;

namespace openTRANS {
    public class TotalTax {
        [XmlElement("TAX_DETAILS_FIX")]
        public TaxDetailsFix TaxDetailsFix { get; set; }
    }
}