using System.Xml.Serialization;

namespace openTRANS
{
    public class FTemplate
    {
        [XmlElement("FT_ID", Namespace = Common.Namespace.bmecat)]
        public string FTId;

        [XmlElement("FT_NAME", Namespace = Common.Namespace.bmecat)]
        public string FTName;

        [XmlElement("FT_SHORTNAME", Namespace = Common.Namespace.bmecat)]
        public string FTShortName;

        [XmlElement("FT_DESCR", Namespace = Common.Namespace.bmecat)]
        public string FTDescription;

        [XmlElement("FT_VERSION", Namespace = Common.Namespace.bmecat)]
        public FTVersion FTVersion = new FTVersion();

        [XmlElement("FT_GROUP_IDREF", Namespace = Common.Namespace.bmecat)]
        public string FTGroupIdRef;

        [XmlElement("FT_GROUP_NAME", Namespace = Common.Namespace.bmecat)]
        public string FTGroupName;

        [XmlElement("FT_DEPENDENCIES", Namespace = Common.Namespace.bmecat)]
        public FTDependencies FTDependencies = new FTDependencies();

        [XmlElement("FEATURE_CONTENT", Namespace = Common.Namespace.bmecat)]
        public FeatureContent FeatureContent = new FeatureContent();
    }
}