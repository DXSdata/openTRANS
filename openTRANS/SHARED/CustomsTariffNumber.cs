using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class CustomsTariffNumber {
        [XmlElement("CUSTOMER_NUMBER")]
        public string CustomsNumber { get; set; }

        [XmlElement("TERRITORY", Namespace = Namespace.bmecat)]
        public List<string> Territory { get; set; }

        [XmlElement("AREA_REFS", Namespace = Namespace.bmecat)]
        public AreaRefs AreaRefs { get; set; }
    }
}