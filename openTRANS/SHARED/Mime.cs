using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class Mime {
        [XmlElement("MIME_TYPE", Namespace = Namespace.bmecat)]
        public string MimeType;

        [XmlElement("MIME_SOURCE", Namespace = Namespace.bmecat)]
        public string MimeSource;

        [XmlElement("FILE_HASH_VALUE")]
        public TypedLangItem FileHashValue = new TypedLangItem();

        [XmlElement("MIME_EMBEDDED")]
        public MimeEmbedded MimeEmbedded = new MimeEmbedded();

        [XmlElement("MIME_DESCR", Namespace = Namespace.bmecat)]
        public string MimeDescription;

        [XmlElement("MIME_ALT", Namespace = Namespace.bmecat)]
        public string MimeAlt;

        [XmlElement("MIME_PURPOSE")]
        public string MimePurpose;

        [XmlElement("MIME_ORDER", Namespace = Namespace.bmecat)]
        public int MimeOrder;
    }
}