using System.Xml.Serialization;

namespace openTRANS {
    public class PackageInfo {
        [XmlElement("PACKAGE")]
        public Package Package { get; set; }
    }
}