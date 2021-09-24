using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class Dimensions {
        [XmlElement("VOLUME", Namespace = Namespace.bmecat, IsNullable = false)]
        public decimal Volume { get; set; }

        [XmlElement("WEIGHT", Namespace = Namespace.bmecat, IsNullable = false)]
        public decimal Weight { get; set; }

        [XmlElement("LENGTH", Namespace = Namespace.bmecat, IsNullable = false)]
        public decimal Length { get; set; }

        [XmlElement("WIDTH", Namespace = Namespace.bmecat, IsNullable = false)]
        public decimal Width { get; set; }

        [XmlElement("DEPTH", Namespace = Namespace.bmecat, IsNullable = false)]
        public decimal Depth { get; set; }
    }
}