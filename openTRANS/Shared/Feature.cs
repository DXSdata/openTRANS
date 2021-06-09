using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public partial class Feature
    {
        [XmlElement("FNAME", Namespace = Common.Namespace.bmecat)]
        public string FName;

        [XmlElement("FNAME", Namespace = Common.Namespace.bmecat)]
        public string FTIdRef;

        [XmlElement("FNAME", Namespace = Common.Namespace.bmecat)]
        public FTemplate FTemplate = new FTemplate();

        [XmlElement("FVALUE", Namespace = Common.Namespace.bmecat)]
        public List<string> FValue = new List<string>();

        [XmlElement("VALUE_IDREF", Namespace = Common.Namespace.bmecat)]
        public List<string> ValueIdRef = new List<string>();

        [XmlElement("FUNIT", Namespace = Common.Namespace.bmecat)]
        public string FUnit;

        [XmlElement("FORDER", Namespace = Common.Namespace.bmecat)]
        public int FOrder;

        [XmlElement("FDESCR", Namespace = Common.Namespace.bmecat)]
        public string FDescription;

        [XmlElement("FVALUE_DETAILS", Namespace = Common.Namespace.bmecat)]
        public string FValueDetails;

        [XmlElement("FVALUE_TYPE", Namespace = Common.Namespace.bmecat)]
        public string FValueType;
    }
}
