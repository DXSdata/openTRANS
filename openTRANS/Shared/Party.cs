using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class Party
    {
        [XmlElement("PARTY_ID", Namespace = Namespace.bmecat)]
        public TypedItem PartyId = new TypedItem();
                
        [XmlElement("PARTY_ROLE")]
        public string PartyRole;

        [XmlElement("ADDRESS")]
        public Address Address = new Address();

        [XmlElement("ACCOUNT")]
        public Account Account = new Account();

        [XmlElement("MIME_INFO")]
        public MimeInfo MimeInfo = new MimeInfo();
    }
}
