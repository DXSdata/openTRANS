using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS {
    public class Account {
        [XmlElement("HOLDER")]
        public string Holder;

        [XmlElement("BANK_ACCOUNT")]
        public TypedItem BankAccount = new TypedItem();

        [XmlElement("BANK_CODE")]
        public TypedItem BankCode = new TypedItem();

        [XmlElement("BANK_NAME")]
        public string BankName;

        [XmlElement("BANK_COUNTRY")]
        public string BankCountry;
    }
}