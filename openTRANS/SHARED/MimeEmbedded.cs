using System.Xml.Serialization;

namespace openTRANS
{
    public class MimeEmbedded
    {
        [XmlAttribute("lang")]
        public string Lang;

        [XmlElement("MIME_DATA", IsNullable = false)]
        public MimeData MimeData = new MimeData();

        [XmlElement("FILE_NAME", IsNullable = false)]
        public string FileName = null;

        [XmlElement("FILE_SIZE", IsNullable = false)]
        public uint FileSize;
    }
}