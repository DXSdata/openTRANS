using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class FeatureContent
    {
        [XmlElement("FT_DATATYPE", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTDataType;

        [XmlElement("FT_FACETS", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public FTFacets FTFacets = null;

        [XmlElement("FT_VALUES", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public FTValues FTValues = null;

        [XmlElement("FT_VALENCY", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTValency = null;

        [XmlElement("FT_UNIT_REF", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTUnitRef = null;

        [XmlElement("FT_UNIT", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTUnit = null;

        [XmlElement("FT_MANDATORY", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public bool FTMandatory;

        [XmlElement("FT_ORDER", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public int FTOrder;

        [XmlElement("FT_SYMBOL", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTSymbol = null;

        [XmlElement("FT_SYNONYMS", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public FTSynonyms FTSynonyms = null;

        [XmlElement("MIME_INFO", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public MimeInfo MimeInfo = null;

        [XmlElement("FT_SOURCE", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public FTSource FTSource = null;

        [XmlElement("FT_NOTE", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTNote = null;

        [XmlElement("FT_REMARK", Namespace = Common.Namespace.bmecat, IsNullable = false)]
        public string FTRemark = null;
    }
}