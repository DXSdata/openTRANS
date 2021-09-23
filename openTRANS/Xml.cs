using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace openTRANS {
    public static class Xml {
        //private readonly string xmlVersion = "1.0";
        //private readonly Encoding encoding = new UpperCaseUTF8Encoding(); //Previously Encoding.Utf8; in case of changing also change StringWriter below; would otherwise produce wrong xml encoding attribute
        //private readonly bool standalone = true;

        //private readonly XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";


        static Xml() {
        }

        public static string Serialize<T>(T o) where T : class, new() {

            var xmlns = new XmlSerializerNamespaces();
            xmlns.Add(nameof(Common.Namespace.xsi), Common.Namespace.xsi);
            xmlns.Add(nameof(Common.Namespace.bmecat), Common.Namespace.bmecat);
            xmlns.Add(nameof(Common.Namespace.xmime), Common.Namespace.xmime);
            xmlns.Add(nameof(Common.Namespace.xsig), Common.Namespace.xsi);


            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var writer = new UTF8StringWriter()) {
                serializer.Serialize(writer, o, xmlns);
                return writer.ToString();
            }
        }

        public static T Deserialize<T>(string xml) where T : class, new() {
            var serializer = new XmlSerializer(typeof(T));

            using (TextReader reader = new StringReader(xml)) {
                return (T)serializer.Deserialize(reader);
            }
        }
        //https://stackoverflow.com/questions/3871738/force-xdocument-to-write-to-string-with-utf-8-encoding
        private class Utf8StringWriter : StringWriter {
            public override Encoding Encoding { get { return Encoding.UTF8; } }
        }

        //writes UTF-8 in uppercase; see class below
        private class UTF8StringWriter : StringWriter {
            public override Encoding Encoding { get { return new UpperCaseUTF8Encoding(); } }
        }


        /// <summary>
        /// Sometimes utf-8 definition in first line needed in uppercase by suppliers.
        /// https://stackoverflow.com/questions/4291332/utf-8-in-uppercase
        /// </summary>
        public class UpperCaseUTF8Encoding : UTF8Encoding {

            public override string WebName => base.WebName.ToUpper();

            public static UpperCaseUTF8Encoding UpperCaseUTF8 {
                get {
                    if (upperCaseUtf8Encoding == null)
                        upperCaseUtf8Encoding = new UpperCaseUTF8Encoding();
                    return upperCaseUtf8Encoding;
                }
            }

            private static UpperCaseUTF8Encoding upperCaseUtf8Encoding = null;
        }
    }
}
