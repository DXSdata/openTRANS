using System;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class ProductId
    {
        [XmlElement("SUPPLIER_PID", Namespace = Common.Namespace.bmecat)]
        public string SupplierPid;

        [XmlElement("BUYER_PID", Namespace = Common.Namespace.bmecat)]
        public TypedItem BuyerPid = new TypedItem();

        [XmlElement("DESCRIPTION_SHORT", Namespace = Common.Namespace.bmecat)]
        public string DescriptionShort;

        [XmlElement("DESCRIPTION_LONG", Namespace = Common.Namespace.bmecat)]
        public string DescriptionLong;

    }
}
