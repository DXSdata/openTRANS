using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class ContactDetails
    {
        [XmlElement("CONTACT_ID", Namespace = Namespace.bmecat, IsNullable = false)]
        public string ContactId = null;

        [XmlElement("CONTACT_NAME", Namespace = Namespace.bmecat)]
        public string ContactName;

        [XmlElement("FIRST_NAME", Namespace = Namespace.bmecat, IsNullable = false)]
        public string FirstName = null;

        [XmlElement("TITLE", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Title = null;

        [XmlElement("ACADEMIC_TITLE", Namespace = Namespace.bmecat, IsNullable = false)]
        public string AcademicTitle = null;

        [XmlElement("CONTACT_ROLE", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem ContactRole = null;

        [XmlElement("CONTACT_DESCR", Namespace = Namespace.bmecat, IsNullable = false)]
        public string ContactDescription = null;

        [XmlElement("PHONE", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem Phone = null;

        [XmlElement("FAX", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem Fax = null;

        [XmlElement("URL", Namespace = Namespace.bmecat, IsNullable = false)]
        public string Url = null;

        [XmlArray("EMAILS", Namespace = Namespace.bmecat, IsNullable = false)]
        [XmlArrayItem("EMAIL")]
        public List<Email> Emails = null;

        [XmlElement("AUTHENTIFICATION", Namespace = Namespace.bmecat, IsNullable = false)]
        public Authentification Authentification = null;

    }
}
