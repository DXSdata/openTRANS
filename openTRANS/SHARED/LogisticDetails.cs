using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class LogisticDetails {
        [XmlElement("CUSTOMS_TARIFF_NUMBER", Namespace = Namespace.bmecat)]
        public CustomsTariffNumber CustomsTariffNumber { get; set; }

        [XmlElement("STATISTICS_FACTOR", Namespace = Namespace.bmecat)]
        public decimal StatisticsFactor { get; set; }

        [XmlElement("COUNTRY_OF_ORIGIN", Namespace = Namespace.bmecat)]
        public string CountryOfOrigin { get; set; }

        [XmlElement("PRODUCT_DIMENSIONS", Namespace = Namespace.bmecat)]
        public Dimensions ProductDimensions { get; set; }

        [XmlElement("SPECIAL_TREATMENT_CLASS", Namespace = Namespace.bmecat)]
        public TypedItem SpecialTreatmentClass { get; set; }

        [XmlElement("TRANSPORT", Namespace = Namespace.bmecat)]
        public Transport Transport { get; set; }

        [XmlElement("PACKAGE_INFO")]
        public PackageInfo PackageInfo { get; set; }

        [XmlElement("MEANS_OF_TRANSPORT", Namespace = Namespace.bmecat)]
        public MeansOfTransport MeansOfTransport { get; set; }

    }
}