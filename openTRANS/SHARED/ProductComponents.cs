using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class ProductComponents
    {
        [XmlElement("PRODUCT_COMPONENTS", Namespace = Namespace.bmecat)]
        public List<ProductComponent> ProductComponent = new ();
    }
}