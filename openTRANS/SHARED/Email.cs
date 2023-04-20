using System;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class Email
    {
        [XmlElement("EMAIL", Namespace = Namespace.bmecat)]
        public string EMail;

        [XmlElement("PUBLIC_KEY", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem PublicKey = null;
    }
}