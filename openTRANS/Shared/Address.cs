using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class Address
    {
        [XmlElement("NAME", Namespace = Common.Namespace.bmecat)]
        public string Name;

        [XmlElement("CONTACT_DETAILS")]
        public ContactDetails ContactDetails = new ContactDetails();

        [XmlElement("STREET", Namespace = Common.Namespace.bmecat)]
        public string Street;

        [XmlElement("ZIP", Namespace = Common.Namespace.bmecat)]
        public string Zip;

        [XmlElement("CITY", Namespace = Common.Namespace.bmecat)]
        public string City;

        [XmlElement("COUNTRY", Namespace = Common.Namespace.bmecat)]
        public string Country;

        [XmlElement("COUNTRY_CODED", Namespace = Common.Namespace.bmecat)]
        public string CountryCoded;

        [XmlElement("PHONE", Namespace = Common.Namespace.bmecat)]
        public TypedItem Phone = new TypedItem();

        [XmlElement("FAX", Namespace = Common.Namespace.bmecat)]
        public TypedItem Fax = new TypedItem();

        [XmlElement("EMAIL", Namespace = Common.Namespace.bmecat)]
        public string Email;
    }
}
