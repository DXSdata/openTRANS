using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class OrderPartiesReference
    {
        [XmlElement("BUYER_IDREF", Namespace = Common.Namespace.bmecat)]
        public TypedItem BuyerIdRef = new TypedItem();

        [XmlElement("SUPPLIER_IDREF", Namespace = Common.Namespace.bmecat)]
        public TypedItem SupplierIdRef = new TypedItem();

        [XmlElement("Invoice_RECIPIENT_IDREF", Namespace = Common.Namespace.bmecat)]
        public TypedItem InvoiceRecipientIdRef = new TypedItem();

        [XmlElement("SHIPMENT_PARTIES_REFERENCE")]
        public ShipmentPartiesReference ShipmentPartiesReference = new ShipmentPartiesReference();

    }
}
