using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public class ProductFeatures
    {
        [XmlElement("REFERENCE_FEATURE_SYSTEM_NAME", Namespace = Namespace.bmecat)]
        public string ReferenceFeatureSystemName;

        [XmlElement("REFERENCE_FEATURE_GROUP_ID", Namespace = Namespace.bmecat)]
        public TypedItem ReferenceFeatureGroupId = new TypedItem();

        [XmlElement("REFERENCE_FEATURE_GROUP_NAME", Namespace = Namespace.bmecat)]
        public string ReferenceFeatureGroupName;

        [XmlElement("REFERENCE_FEATURE_GROUP_ID2", Namespace = Namespace.bmecat)]
        public TypedItem ReferenceFeatureGroupId2 = new TypedItem();

        [XmlElement("GROUP_PRODUCT_ORDER", Namespace = Namespace.bmecat)]
        public int GroupProductOrder;

        [XmlElement("FEATURE", Namespace = Namespace.bmecat)]
        public List<Feature> Features = new List<Feature>();
    }
}