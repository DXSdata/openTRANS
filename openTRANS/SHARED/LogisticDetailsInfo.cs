using System.Xml.Serialization;

namespace openTRANS {
    public class LogisticDetailsInfo {
        [XmlElement("COUNTRY_OF_ORIGIN")]
        public string CountryOfOrigin { get; set; }

        [XmlElement("TRANSPORT")]
        public Transport Transport { get; set; }

        [XmlElement("PACKAGE_INFO")]
        public PackageInfo PackageInfo { get; set; }

        [XmlElement("MEANS_OF_TRANSPORT")]
        public MeansOfTransport MeansOfTransport { get; set; }

    }
}