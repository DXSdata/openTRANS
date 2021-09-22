using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public partial class Address
    {
        [XmlElement("NAME", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Name = null;

        [XmlElement("NAME2", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Name2 = null;

        [XmlElement("NAME3", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Name3 = null;

        [XmlElement("DEPARTMENT", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Department = null;

        [XmlElement("CONTACT_DETAILS", IsNullable = false)]
        public ContactDetails ContactDetails = new ContactDetails();

        [XmlElement("STREET", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Street = null;

        [XmlElement("ZIP", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Zip = null;

        [XmlElement("BOXNO", Namespace = Namespace.bmecat, IsNullable = false)]
        public string BoxNo = null;

        [XmlElement("ZIPBOX", Namespace = Namespace.bmecat, IsNullable = false)]
        public string ZipBox = null;

        [XmlElement("CITY", Namespace = Namespace.bmecat, IsNullable = false)]
        public string City = null;

        [XmlElement("STATE", Namespace = Namespace.bmecat, IsNullable = false)]
        public string State = null;

        [XmlElement("COUNTRY", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Country = null;

        [XmlElement("COUNTRY_CODED", Namespace = Namespace.bmecat, IsNullable = false)]
        public string CountryCoded = null;

        [XmlElement("VAT_ID", Namespace = Namespace.bmecat, IsNullable = false)]
        public string VatId = null;

        [XmlElement("TAX_NUMBER", Namespace = Namespace.bmecat, IsNullable = false)]
        public string TaxNumber = null;

        [XmlElement("PHONE", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem Phone = null;

        [XmlElement("FAX", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem Fax = null;

        [XmlElement("EMAIL", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Email = null;

        [XmlElement("PUBLIC_KEY", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem PublicKey = null;

        [XmlElement("URL", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Url = null;

        [XmlElement("ADDRESS_REMARKS", Namespace = Namespace.bmecat, IsNullable = false)]
        public string AddressRemarks = null;
    }
}
