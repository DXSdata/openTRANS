using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class Package {
        [XmlElement("PACKAGE_ID")]
        public List<TypedItem> PackageId { get; set; }

        [XmlElement("PACKAGE_DESCRIPTION")]
        public string PackageDescription { get; set; }

        [XmlElement("PACKING_UNIT_CODE", Namespace = Namespace.bmecat)]
        public string PackingUnitCode { get; set; }

        [XmlElement("PACKING_UNIT_DESCR", Namespace = Namespace.bmecat)]
        public string PackingUnitDescr { get; set; }

        [XmlElement("PACKING_ORDER_UNIT_QUANTITY")]
        public decimal PackageOrderUnitQuantity { get; set; }

        [XmlElement("PACKAGE_QUANTITY")]
        public decimal PackageQuantity { get; set; }

        [XmlElement("PACKAGE_DIMENSIONS")]
        public Dimensions PackageDimensions { get; set; }

        [XmlElement("MEANS_OF_TRANSPORT_IDREF")]
        public string MeansOfTransportIdref { get; set; }

        [XmlElement("SUB_PACKAGES")]
        public SubPackages SubPackages { get; set; }

    }
}