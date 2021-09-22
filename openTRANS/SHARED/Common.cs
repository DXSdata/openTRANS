
using ISO3166;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace openTRANS
{
    public static class Common
    {
        public static class OrderType
        {
            public const string Standard = "standard";
            public const string Express = "express";
            public const string Release = "release";
            public const string Consignment = "consignment";
        }
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

        public static class PriceFlagType
        {
            public const string InclDuty = "incl_duty";
            public const string InclFreight = "incl_freight";
            public const string InclInsurance = "incl_insurance";
            public const string InclPacking = "incl_packing";
        }

        public static class TaxCategory
        {
            public const string Exemption = "exemption";
            public const string ParkingRate = "parking_rate";
            public const string ReducedRate = "reduced_rate";
            public const string StandardRate = "standard_rate";
            public const string SuperReducedRate = "super_reduced_rate";
            public const string ZeroRate = "zero_rate";
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

        public class TypedLangItem : TypedItem
        {
            public TypedLangItem() { }
            public TypedLangItem(string value = null, string type = null, string lang = null)
                : base(value, type)
            {
                Lang = lang;
            }
            [XmlAttribute("lang")]
            public string Lang;
        }

        public static class MimeTypeType
        {
            public const string PDF = "application/pdf";
            public const string XML = "application/xml";
            public const string GIF = "image/gif";
            public const string JPEG = "image/jpeg";
            public const string HTML = "text/html";
            public const string TXT = "text/plain";
            public const string URL = "url";
        }

        public class Interval
        {
            public Interval()
            {

            }
            public Interval(decimal value = 0, string intervalType = null)
            {
                IntervalType = intervalType;
                Value = value;
            }

            [XmlAttribute("intervaltype")]
            public string IntervalType;
            [XmlText]
            public decimal Value;
        }

        public class IntervalType
        {
            public const string Exclude = "exclude";
            public const string Include = "include";
        }

        public static class MimePurposeType
        {
            public const string Conformity = "conformity";
            public const string DataSheet = "data_sheet";
            public const string Detail = "detail";
            public const string Directions = "directions";
            public const string FaxImage = "fax_image";
            public const string FreehandSketch = "freehand_sketch";
            public const string Icon = "icon";
            public const string Logo = "logo";
            public const string Manual = "manual";
            public const string MountingGuidelines = "mounting_guidelines";
            public const string Normal = "normal";
            public const string OriginalDocument = "original_document";
            public const string RepairManual = "repair_manual";
            public const string SafetyDataSheet = "safety_data_sheet";
            public const string SignatureFile = "signatur_file";
            public const string ServiceDescription = "service_descr";
            public const string ServiceRecord = "service_record";
            public const string Thumbnail = "thumbnail";
            public const string VerificationReport = "verification_report";
            public const string Warranty = "warranty";
            public const string Others = "others";

        }

        public class FileHashType
        {
            public const string SHA512 = "SHA512";
            public const string SHA384 = "SHA384";
            public const string SHA256 = "SHA256";
            public const string SHA1 = "SHA1";
            public const string MD5 = "MD5";
            public const string RIPEMD128 = "RIPEMD128";
            public const string RIPEMD160 = "RIPEMD160";
            public const string RIPEMD256 = "RIPEMD256";
            public const string RIPEMD320 = "RIPEMD320";
            public const string Tiger192 = "Tiger192";
            public const string Tiger160 = "Tiger160";
            public const string Tiger128 = "Tiger128";
            public const string HAVAL = "HAVAL";
            public const string PANAMA = "PANAMA";
            public const string WHIRLPOOL = "WHIRLPOOL";
            public const string LMHash = "LMHash";
            public const string NTLM = "NTLM";
            public const string Custom = "";
        }

        public class FValueType
        {
            public const string Choice = "choice";
            public const string Range = "range";
            public const string Set = "set";
        }

        public class FTFacetType
        {
            public const string MinLength = "minLength";
            public const string MaxLength = "maxLength";
            public const string MinInclusive = "minInclusive";
            public const string MaxInclusive = "maxInclusive";
            public const string MinExclusive = "minExclusive";
            public const string MaxExclusive = "maxExclusive";
            public const string TotalDigits = "totalDigits";
            public const string FractionDigits = "fractionDigits";
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
