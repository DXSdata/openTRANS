using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class Mime {
        [XmlElement("MIME_TYPE", Namespace = Namespace.bmecat, IsNullable = false)]
        public string MimeType = null;

        [XmlElement("MIME_SOURCE", Namespace = Namespace.bmecat, IsNullable = false)]
        public string MimeSource = null;

        [XmlElement("FILE_HASH_VALUE", IsNullable = false)]
        public TypedLangItem FileHashValue = null;

        [XmlElement("MIME_EMBEDDED")]
        public MimeEmbedded MimeEmbedded = null;

        [XmlElement("MIME_DESCR", Namespace = Namespace.bmecat, IsNullable = false)]
        public string MimeDescription = null;

        [XmlElement("MIME_ALT", Namespace = Namespace.bmecat, IsNullable = false)]
        public string MimeAlt = null;

        [XmlElement("MIME_PURPOSE")]
        public string MimePurpose = null;

        [XmlElement("MIME_ORDER", Namespace = Namespace.bmecat, IsNullable = false)]
        public int MimeOrder;
    }
}