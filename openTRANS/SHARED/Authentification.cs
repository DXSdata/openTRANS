using System.Xml.Serialization;

namespace openTRANS {
    public class Authentification {
        [XmlElement("LOGIN", Namespace = Common.Namespace.bmecat)]
        public string Login;

        [XmlElement("PASSWORD", Namespace = Common.Namespace.bmecat)]
        public string Password;
    }
}