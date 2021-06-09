using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class Email {
        [XmlElement("EMAIL", Namespace = Namespace.bmecat)]
        public string EMail;

        [XmlElement("PUBLIC_KEY", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem PublicKey = null;
    }
}