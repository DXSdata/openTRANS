using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class DocExchangePartiesReference {
        [XmlElement("DOCUMENT_ISSUER_IDREF")]
        public TypedItem DocumentIssuerIdRef = new TypedItem();

        [XmlElement("DOCUMENT_RECIPIENT_IDREF")]
        public TypedItem DocumentRecipientIdRef = new TypedItem();
    }
}