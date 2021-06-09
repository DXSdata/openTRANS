using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public class FTValues {
        [XmlElement("FT_VALUES", Namespace = Common.Namespace.bmecat)]
        public List<FTValue> FTValue = new List<FTValue>();
    }
}