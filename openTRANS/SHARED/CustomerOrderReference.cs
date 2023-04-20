using System;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class CustomerOrderReference
    {
        /// <summary>
        /// Customer's own order number
        /// </summary>
        [XmlElement("ORDER_ID")]
        public string OrderId;

        [XmlElement("ORDER_DESCR")]
        public string OrderDescr;

        [XmlElement("LINE_ITEM_ID")]
        public string LineItemId;

        [XmlElement("ORDER_DATE")]
        public DateTime? OrderDate;

        [XmlElement("CUSTOMER_IDREF")]
        public TypedItem CustomerIdRef = new ();
    }
}
