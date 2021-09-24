using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class InvoiceCorrection {
        [XmlElement("INVOICE_REFERENCE")]
        public InvoiceReference InvoiceReference { get; set; }

        [XmlElement("ADJUSTMENT_REASON_DESCR")]
        public string AdjustmentReasonDescr { get; set; }

        [XmlElement("ADJUSTMENT_REASON_CODES")]
        public List<string> AdjustmentReasonCodes { get; set; }
    }
}