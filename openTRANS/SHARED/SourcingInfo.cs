using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class SourcingInfo
    {
        [XmlElement("AGREEMENT")]
        public Agreement Agreement = new ();
    }
}
