using System.Xml.Serialization;

namespace openTRANS {
    public partial class Feature
    {
        [XmlElement("FNAME", Namespace = Common.Namespace.bmecat)]
        public string FName;

        [XmlElement("FVALUE", Namespace = Common.Namespace.bmecat)]
        public string FValue;

        [XmlElement("FUNIT", Namespace = Common.Namespace.bmecat)]
        public string FUnit;
    }
}
