using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public class Account
    {
        [XmlElement("HOLDER")]
        public string Holder;

        [XmlElement("BANK_ACCOUNT")]
        public TypedItem BankAccount = new TypedItem();

        [XmlElement("BANK_CODE", IsNullable = false)]
        public TypedItem BankCode = null;

        [XmlElement("BANK_NAME", IsNullable = false)]
        public string BankName = null;

        [XmlElement("BANK_COUNTRY", IsNullable = false)]
        public string BankCountry = null;
    }
}