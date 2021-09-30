using System.Xml.Serialization;

namespace openTRANS {
    public class DispatchnotificationHeader {
        [XmlElement("CONTROL_INFO")]
        public ControlInfo ControlInfo { get; set; }

        [XmlElement("DISPATCHNOTIFICATION_INFO")]
        public DispatchnotificationInfo DispatchnotificationInfo { get; set; }
    }
}