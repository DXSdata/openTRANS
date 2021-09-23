using System.Xml.Serialization;

namespace openTRANS {
    public class InternationalRestrictions {
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}