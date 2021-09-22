using System.Xml.Serialization;

namespace openTRANS {
    public partial class Language {
        [XmlAttribute("default")]
        public bool Default = true;
    }
}