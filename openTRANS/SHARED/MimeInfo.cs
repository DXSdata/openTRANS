using System.Xml.Serialization;

namespace openTRANS
{
    public class MimeInfo
    {
        [XmlElement("MIME")]
        public Mime Mime = new Mime();
    }
}