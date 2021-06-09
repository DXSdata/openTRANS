
using ISO3166;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace openTRANS
{
    public static class Common
    {
        public static class Namespace
        {
            public const string xsi = "http://www.w3.org/2001/XMLSchema-instance";
            public const string bmecat = "http://www.bmecat.org/bmecat/2005";
            public const string xmime = "http://www.w3.org/2005/05/xmlmime";
            public const string xsig = "http://www.w3.org/2000/09/xmldsig#";

            public const string custom = "custom";
        }

        public static class PartyType
        {
            public const string BuyerSpecific = "buyer_specific"; 
            public const string CustomerSpecific = "customer_specific,";
            public const string DUNS = "duns"; 
            public const string ILN = "iln"; 
            public const string GLN = "gln"; 
            public const string PartySpecific = "party_specific";
            public const string SupplierSpecific = "supplier_specific";

            /// <summary>
            /// Not in OT Standard; for custom use
            /// </summary>
            public const string ERPlusSpecific = "erplus_specific";            
        }

        public static class PartyRole
        {
            public const string Buyer = "buyer";
            public const string CentralRegulator = "central_regulator";
            public const string Customer = "customer";
            public const string Deliverer = "deliverer";
            public const string Delivery = "delivery";
            public const string DocumentCreator = "document_creator";
            public const string FinalDelivery = "final_delivery";
            public const string Intermediary = "intermediary";
            public const string InvoiceIssuer = "invoice_issuer";
            public const string InvoiceRecipient = "invoice_recipient";
            public const string IppOperator = "ipp_operator";
            public const string Manufacturer = "manufacturer";
            public const string Marketplace = "marketplace";
            public const string Payer = "payer";
            public const string Remittee = "remittee";
            public const string StandardizationBody = "standardization_body";
            public const string Supplier = "supplier";
            public const string TrustedThirdParty = "trustedthirdparty";
            public const string Other = "other";            
        }

        public static class OrderUnit
        {
            public const string Centimeter = "CMT";
            public const string Piece = "C62";
            public const string Kilogram = "KGM";
            public const string Liter = "LTR";
            public const string Millimeter = "MMT";
            public const string Meter = "MTR";
            public const string PackOf2 = "OP";
            public const string Packet = "PA";
        }

        public static class AllowOrChargeTypes //exceptional plural to differ from AllowOrChargeType class
        {
            public const string Allowance = "allowance";
            public const string Surcharge = "surcharge";            
        }

        public static class AllowOrChargeTypeType
        {
            public const string ProjectBonus = "project_bonus";
            public const string OverPackaging = "overpackaging";
            public const string Rebate = "rebate";
            public const string Recycling = "recycling";
            public const string SmallOrder = "small_order";
            public const string SpecialWorkTimes = "special_work_times";
            public const string Toll = "toll";
        }

        public static class PhoneType
        {
            public const string Mobile = "mobile";
            public const string Office = "office";
            public const string Private = "private";            
        }

        public static class DeliveryDateType
        {
            public const string Optional = "optional";
            public const string Fixed = "fixed";
        }

        public class TypedItem
        {
            public TypedItem() //needed for serializer
            {
            }
            public TypedItem(string value = null, string type = null)
            {
                Value = value;
                Type = type;
            }

            [XmlText]
            public string Value;

            [XmlAttribute("type")]
            public string Type;
        }

        public static void Add(this List<TypedItem> list, string value = null, string type = null)
        {
            list.Add(new TypedItem(value, type));
        }

        public static string GetCountryCode(string countryName)
        {
            var country = Country.List.FirstOrDefault(c => c.Name == countryName);

            return country?.ThreeLetterCode;
        }
    }
}
