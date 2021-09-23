using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace openTRANS {
    [XmlRoot("QUOTATION", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public partial class Quotation {
        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation = "http://www.opentrans.org/XMLSchema/2.1%20opentrans_2_1.xsd";

        [XmlAttribute("version")]
        public const string Version = "2.1";

        [XmlElement("QUOTATION_HEADER")]
        public QuotationHeader QuotationHeader { get; set; } = new QuotationHeader();

        [XmlArray("QUOTATION_ITEM_LIST")]
        [XmlArrayItem("QUOTATION_ITEM")]
        public List<QuotationItem> QuotationItemList { get; set; } = new List<QuotationItem>();

        [XmlElement("QUOTATION_SUMMARY")]
        public QuotationSummary QuotationSummary {
            get {
                return new QuotationSummary(this);
            }
            set { }
        }
    }
}
