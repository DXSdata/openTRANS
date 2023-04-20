using System;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class DocExchangePartiesReference
    {
        [XmlElement("DOCUMENT_ISSUER_IDREF")]
        public TypedItem DocumentIssuerIdRef = new ();

        [XmlElement("DOCUMENT_RECIPIENT_IDREF")]
        public TypedItem DocumentRecipientIdRef = new ();
    }
}