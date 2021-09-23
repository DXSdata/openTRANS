using System.Xml.Serialization;

namespace openTRANS {
    public class CatalogReference {
        [XmlElement("CATALOG_ID")]
        public string CatalogId { get; set; }

        [XmlElement("CATALOG_VERSION")]
        public string CatalogVersion { get; set; }

        [XmlElement("CATALOG_NAME")]
        public string CatalogName { get; set; }

    }
}