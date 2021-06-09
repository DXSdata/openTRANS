using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class ProductComponents {
        [XmlElement("PRODUCT_COMPONENTS", Namespace = Namespace.bmecat)]
        public List<ProductComponent> ProductComponent = new List<ProductComponent>();
    }
}