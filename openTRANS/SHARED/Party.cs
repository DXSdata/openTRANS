using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class Party
    {
        [XmlElement("PARTY_ID", Namespace = Namespace.bmecat)]
        public TypedItem PartyId = new TypedItem();
                
        [XmlElement("PARTY_ROLE", IsNullable = false)]
        public string PartyRole = null;

        [XmlElement("ADDRESS", IsNullable = false)]
        public Address Address = null;

        [XmlElement("ACCOUNT", IsNullable = false)]
        public Account Account =null;

        [XmlElement("MIME_INFO", IsNullable = false)]
        public MimeInfo MimeInfo = null;
    }
}
