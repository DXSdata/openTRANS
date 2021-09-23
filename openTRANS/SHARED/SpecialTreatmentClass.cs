using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class SpecialTreatmentClass {
        [XmlAttribute("type", Namespace = Namespace.bmecat)]
        public string Type { get; set; }
    }
}