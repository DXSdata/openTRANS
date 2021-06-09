using System.Xml.Serialization;

namespace openTRANS {
    public partial class Party
    {
        [XmlElement("PARTY_ID", Namespace = Common.Namespace.bmecat)]
        public PartyId PartyId = new PartyId();
                
        [XmlElement("PARTY_ROLE")]
        public string PartyRole;

        [XmlElement("ADDRESS")]
        public Address Address = new Address();

    }
}
