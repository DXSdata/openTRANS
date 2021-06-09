using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class Address
    {
        [XmlElement("NAME", Namespace = Common.Namespace.bmecat)]
        public string Name;

        [XmlElement("NAME2", Namespace = Common.Namespace.bmecat)]
        public string Name2;

        [XmlElement("NAME3", Namespace = Common.Namespace.bmecat)]
        public string Name3;

        [XmlElement("DEPARTMENT", Namespace = Common.Namespace.bmecat)]
        public string Department;

        [XmlElement("CONTACT_DETAILS")]
        public ContactDetails ContactDetails = new ContactDetails();

        [XmlElement("STREET", Namespace = Common.Namespace.bmecat)]
        public string Street;

        [XmlElement("ZIP", Namespace = Common.Namespace.bmecat)]
        public string Zip;

        [XmlElement("BOXNO", Namespace = Common.Namespace.bmecat)]
        public string BoxNo;

        [XmlElement("ZIPBOX", Namespace = Common.Namespace.bmecat)]
        public string ZipBox;

        [XmlElement("CITY", Namespace = Common.Namespace.bmecat)]
        public string City;

        [XmlElement("STATE", Namespace = Common.Namespace.bmecat)]
        public string State;

        [XmlElement("COUNTRY", Namespace = Common.Namespace.bmecat)]
        public string Country;

        [XmlElement("COUNTRY_CODED", Namespace = Common.Namespace.bmecat)]
        public string CountryCoded;

        [XmlElement("VAT_ID", Namespace = Common.Namespace.bmecat)]
        public string VatId;

        [XmlElement("TAX_NUMBER", Namespace = Common.Namespace.bmecat)]
        public string TaxNumber;

        [XmlElement("PHONE", Namespace = Common.Namespace.bmecat)]
        public TypedItem Phone = new TypedItem();

        [XmlElement("FAX", Namespace = Common.Namespace.bmecat)]
        public TypedItem Fax = new TypedItem();

        [XmlElement("EMAIL", Namespace = Common.Namespace.bmecat)]
        public string Email;

        [XmlElement("PUBLIC_KEY", Namespace = Common.Namespace.bmecat)]
        public TypedItem PublicKey = new TypedItem();

        [XmlElement("URL", Namespace = Common.Namespace.bmecat)]
        public string Url;

        [XmlElement("ADDRESS_REMARKS", Namespace = Common.Namespace.bmecat)]
        public string AddressRemarks;
    }
}
