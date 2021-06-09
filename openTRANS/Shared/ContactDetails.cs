using System.Xml.Serialization;

namespace openTRANS {
    public partial class ContactDetails
    {
        [XmlElement("CONTACT_NAME", Namespace = Common.Namespace.bmecat)]
        public string ContactName;
    }
}
