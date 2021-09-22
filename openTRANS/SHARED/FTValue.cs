using System.Xml.Serialization;

namespace openTRANS
{
    public class FTValue
    {
        [XmlElement("VALUE_IDREF", Namespace = Common.Namespace.bmecat)]
        public string ValueIdRef;

        [XmlElement("VALUE_SIMPLE", Namespace = Common.Namespace.bmecat)]
        public string ValueSimple;

        [XmlElement("VALUE_TEXT", Namespace = Common.Namespace.bmecat)]
        public string ValueText;

        [XmlElement("VALUE_RANGE", Namespace = Common.Namespace.bmecat)]
        public ValueRange ValueRange = new ValueRange();

        [XmlElement("MIME_INFO", Namespace = Common.Namespace.bmecat)]
        public MimeInfo MimeInfo = new MimeInfo();

        [XmlElement("VALUE_ORDER", Namespace = Common.Namespace.bmecat)]
        public int ValueOrder;

        [XmlElement("DEFAULT_FLAG", Namespace = Common.Namespace.bmecat)]
        public bool DefaultFlag;
    }
}