using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class ContactDetails
    {
        [XmlElement("CONTACT_ID", Namespace = Common.Namespace.bmecat)]
        public string ContactId;
        [XmlElement("CONTACT_NAME", Namespace = Common.Namespace.bmecat)]
        public string ContactName;

        [XmlElement("FIRST_NAME", Namespace = Common.Namespace.bmecat)]
        public string FirstName;

        [XmlElement("TITLE", Namespace = Common.Namespace.bmecat)]
        public string Title;

        [XmlElement("ACADEMIC_TITLE", Namespace = Common.Namespace.bmecat)]
        public string AcademicTitle;

        [XmlElement("CONTACT_ROLE", Namespace = Common.Namespace.bmecat)]
        public TypedItem ContactRole = new TypedItem();

        [XmlElement("CONTACT_DESCR", Namespace = Common.Namespace.bmecat)]
        public string ContactDescription;

        [XmlElement("PHONE", Namespace = Common.Namespace.bmecat)]
        public TypedItem Phone = new TypedItem();

        [XmlElement("FAX", Namespace = Common.Namespace.bmecat)]
        public TypedItem Fax = new TypedItem();

        [XmlElement("URL", Namespace = Common.Namespace.bmecat)]
        public string Url;

        [XmlArray("EMAILS", Namespace = Common.Namespace.bmecat)]
        [XmlArrayItem("EMAIL")]
        public List<string> Emails = new List<string>();

        [XmlElement("AUTHENTIFICATION", Namespace = Common.Namespace.bmecat)]
        public Authentification Authentification = new Authentification();

    }
}
