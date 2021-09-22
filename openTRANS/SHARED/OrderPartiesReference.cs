using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public partial class OrderPartiesReference {
        [XmlElement("BUYER_IDREF", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem BuyerIdRef = new TypedItem();

        [XmlElement("SUPPLIER_IDREF", Namespace = Namespace.bmecat, IsNullable = false)]
        public TypedItem SupplierIdRef = new TypedItem();

        [XmlElement("Invoice_RECIPIENT_IDREF", IsNullable = false)]
        public TypedItem InvoiceRecipientIdRef = null;

        [XmlElement("SHIPMENT_PARTIES_REFERENCE", IsNullable = false)]
        public ShipmentPartiesReference ShipmentPartiesReference = null;

    }
}
