using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class DispatchnotificationInfo {
        [XmlElement("DISPATCHNOTIFICATION_ID")]
        public string DispatchnotificationId { get; set; }

        [XmlElement("DISPATCHNOTIFICATION_DATE")]
        public DateTime DispatchnotificationDate { get; set; }

        [XmlElement("LANGUAGE")]
        public Language Language { get; set; }

        [XmlElement("MIME_ROOT")]
        public string MimeRoot { get; set; }

        [XmlElement("DELIVERY_DATE")]
        public DeliveryDate DeliveryDate { get; set; }

        [XmlArray("PARTIES")]
        [XmlArrayItem("PARTY")]
        public List<Party> Parties { get; set; }

        [XmlElement("SUPPLIER_IDREF")]
        public TypedItem SupplierIdref { get; set; }

        [XmlElement("BUYER_IDREF")]
        public TypedItem BuyerIdref { get; set; }

        [XmlElement("SHIPMENT_PARTIES_REFERENCE")]
        public ShipmentPartiesReference ShipmentPartiesReference { get; set; }

        [XmlElement("SHIPMENT_ID")]
        public string ShipmentId { get; set; }

        [XmlElement("TRACKING_TRACING_URL")]
        public string TrackingTracingUrl { get; set; }

        [XmlElement("DOCEXCHANGE_PARTIES_REFERENCE")]
        public DocExchangePartiesReference DocExchangePartiesReference { get; set; }

        [XmlElement("LOGISTC_DETAILS_INFO")]
        public LogisticDetailsInfo LogisticDetailsInfo { get; set; }

        [XmlElement("INTERNATIONAL_RESTRICTIONS")]
        public TypedItem InternationalRestrictions { get; set; }

        [XmlElement("MIMEN_INFO")]
        public MimeInfo MimeInfo { get; set; }

        [XmlElement("REMARKS")]
        public List<TypedItem> Remarks { get; set; }
    }
}