using System.Xml.Serialization;

namespace openTRANS {
    public partial class AllowOrCharge
    {
        [XmlAttribute("type")]
        public string Type;

        [XmlElement("ALLOW_OR_CHARGE_SEQUENCE")]
        public int AllowOrChageSequence;

        [XmlElement("ALLOW_OR_CHARGE_NAME")]
        public string AllowOrChargeName;

        [XmlElement("ALLOW_OR_CHARGE_TYPE")]
        public string AllowOrChargeType;

        [XmlElement("ALLOW_OR_CHARGE_DESCR")]
        public string AllowOrChargeDescr;       

        [XmlElement("ALLOW_OR_CHARGE_VALUE")]
        public AllowOrChargeValue AllowOrChargeValue = new AllowOrChargeValue();
    }
}
