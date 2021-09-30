using System.Xml.Serialization;

namespace openTRANS {
    public class DispatchnotificationSummary {
        public DispatchnotificationSummary() {

        }
        public DispatchnotificationSummary(Dispatchnotification dispatchnotification) {
            TotalItemNum = dispatchnotification.DispatchnotificationItemList.Count;
        }

        [XmlElement("TOTAL_ITEM_NUM")]
        public int TotalItemNum { get; set; }
    }
}