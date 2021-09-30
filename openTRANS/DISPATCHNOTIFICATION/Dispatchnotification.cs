using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace openTRANS {
    [XmlRoot("DISPATCHNOTIFICATION", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public class Dispatchnotification {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation => "http://www.opentrans.org/XMLSchema/2.1%20opentrans_2_1.xsd";

        [XmlAttribute("version")]
        public string Version => "2.1";

        [XmlElement("DISPATCHNOTIFICATION_HEADER")]
        public DispatchnotificationHeader DispatchnotificationHeader { get; set; }

        [XmlArray("DISPATCHNOTIFICATION_ITEM_LIST")]
        [XmlArrayItem("DISPATCHNOTIFICATION_ITEM")]
        public List<DispatchnotificationItem> DispatchnotificationItemList { get; set; }

        [XmlElement("DISPATCHNOTIFICATION_SUMMARY")]
        public DispatchnotificationSummary DispatchnotificationSummary { 
            get => new DispatchnotificationSummary(this); 
            set { } 
        }
    }
}
