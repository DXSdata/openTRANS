using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class Authentification
    {
        [XmlElement("LOGIN", Namespace = Common.Namespace.bmecat)]
        public string Login;

        [XmlElement("PASSWORD", Namespace = Common.Namespace.bmecat)]
        public string Password;
    }
}