using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class Language
    {
        [XmlAttribute("default")]
        public bool Default = true;
    }
}