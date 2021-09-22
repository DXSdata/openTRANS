using System.Xml.Serialization;

namespace openTRANS
{
    public partial class SourcingInfo
    {
        [XmlElement("AGREEMENT")]
        public Agreement Agreement = new Agreement();
    }
}
