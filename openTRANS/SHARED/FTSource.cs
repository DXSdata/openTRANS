using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class FTSource {
        [XmlElement("SOURCE_NAME", Namespace = Namespace.bmecat)]
        public string SourceName;

        [XmlElement("SOURCE_URI", Namespace = Namespace.bmecat)]
        public string SourceUri;

        [XmlElement("PARTY_IDREF", Namespace = Namespace.bmecat)]
        public TypedItem PartyIdRef = new TypedItem();
    }
}