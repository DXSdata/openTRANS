using System.Xml.Serialization;

namespace openTRANS {
    public class FeatureContent {
        [XmlElement("FT_DATATYPE", Namespace = Common.Namespace.bmecat)]
        public string FTDataType;

        [XmlElement("FT_FACETS", Namespace = Common.Namespace.bmecat)]
        public FTFacets FTFacets = new FTFacets();

        [XmlElement("FT_VALUES", Namespace = Common.Namespace.bmecat)]
        public FTValues FTValues = new FTValues();

        [XmlElement("FT_VALENCY", Namespace = Common.Namespace.bmecat)]
        public string FTValency;

        [XmlElement("FT_UNIT_REF", Namespace = Common.Namespace.bmecat)]
        public string FTUnitRef;

        [XmlElement("FT_UNIT", Namespace = Common.Namespace.bmecat)]
        public string FTUnit;

        [XmlElement("FT_MANDATORY", Namespace = Common.Namespace.bmecat)]
        public bool FTMandatory;

        [XmlElement("FT_ORDER", Namespace = Common.Namespace.bmecat)]
        public int FTOrder;

        [XmlElement("FT_SYMBOL", Namespace = Common.Namespace.bmecat)]
        public string FTSymbol;

        [XmlElement("FT_SYNONYMS", Namespace = Common.Namespace.bmecat)]
        public FTSynonyms FTSynonyms = new FTSynonyms();

        [XmlElement("MIME_INFO", Namespace = Common.Namespace.bmecat)]
        public MimeInfo MimeInfo = new MimeInfo();

        [XmlElement("FT_SOURCE", Namespace = Common.Namespace.bmecat)]
        public FTSource FTSource = new FTSource();

        [XmlElement("FT_NOTE", Namespace = Common.Namespace.bmecat)]
        public string FTNote;

        [XmlElement("FT_REMARK", Namespace = Common.Namespace.bmecat)]
        public string FTRemark;
    }
}