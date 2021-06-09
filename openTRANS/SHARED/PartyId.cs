using System.Xml.Serialization;

namespace openTRANS {
    public partial class PartyId
    {
        [XmlText]
        public string Value;

        [XmlAttribute("type")]
        public string Type;
    }
}
