using System.Xml.Serialization;

namespace openTRANS {
    public class MimeEmbedded {
        [XmlAttribute("lang")]
        public string Lang;

        [XmlElement("MIME_DATA")]
        public MimeData MimeData = new MimeData();

        [XmlElement("FILE_NAME")]
        public string FileName;

        [XmlElement("FILE_SIZE")]
        public uint FileSize;
    }
}