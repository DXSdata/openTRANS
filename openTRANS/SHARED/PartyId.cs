using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class PartyId
    {
        [XmlText]
        public string Value;

        [XmlAttribute("type")]
        public string Type;
    }
}
