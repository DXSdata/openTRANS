using System.Xml.Serialization;

namespace openTRANS {
    public class AreaRefs {
        [XmlElement("AREA_IDREF")]
        public string AreaIdref { get; set; }
    }
}