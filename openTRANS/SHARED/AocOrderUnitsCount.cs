using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class AocOrderUnitsCount
    {
        [XmlAttribute("type")]
        public string Type;
    }
}
