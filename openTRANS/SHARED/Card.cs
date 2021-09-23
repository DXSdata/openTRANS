using System;
using System.Xml.Serialization;

namespace openTRANS {
    public class Card {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("CARD_NUM")]
        public string CardNum { get; set; }

        [XmlElement("CARD_AUTH_CODE")]
        public string CardAuthCode { get; set; }

        [XmlElement("CARD_REF_NUM")]
        public string CardRefNum { get; set; }

        [XmlElement("CARD_EXPIRATION_DATE")]
        public DateTime CardExpirationDate{ get; set; }

        [XmlElement("CARD_HOLDER_NAME")]
        public string CardHolderName { get; set; }
    }
}