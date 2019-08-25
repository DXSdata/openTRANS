using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace openTRANS
{
    public class XmlCreator
    {
        private string xmlVersion = "1.0";
        private Encoding encoding = Encoding.UTF8; //In case of changing also change StringWriter below; would otherwise produce wrong xml encoding attribute
        private bool standalone = true;

        //private XNamespace xmlns = "http://www.opentrans.org/XMLSchema/2.1";
        private XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        private string schemaLocation = "http://www.opentrans.org/XMLSchema/2.1%20opentrans_2_1.xsd";
        private string bmecat = "http://www.bmecat.org/bmecat/2005";
        private string xmime = "http://www.w3.org/2005/05/xmlmime";
        private string xsig = "http://www.w3.org/2000/09/xmldsig#";

        private string version = "2.1";
        private string type = "standard";

        private Order order;

        private const string OrderHeader = "ORDER_HEADER";
        private const string ControlInfo = "CONTROL_INFO";
        private const string ControlInfoGenerationDate = "GENERATION_DATE";

        public XmlCreator(Order order)
        {
            this.order = order;
        }
               
        public string Result
        {
            get
            {
                var xdoc = new XDocument(
                    new XDeclaration(xmlVersion, encoding.WebName.ToUpper(), standalone ? "yes" : "no")
                    );

               
                var xmlns = new XmlSerializerNamespaces();
                xmlns.Add(nameof(Common.Namespace.xsi), Common.Namespace.xsi);
                xmlns.Add(nameof(Common.Namespace.bmecat), Common.Namespace.bmecat);
                xmlns.Add(nameof(Common.Namespace.xmime), Common.Namespace.xmime);
                xmlns.Add(nameof(Common.Namespace.xsig), Common.Namespace.xsi);


                XmlSerializer serializer = new XmlSerializer(typeof(Order));
                using (var writer = new Utf8StringWriter())
                {
                    serializer.Serialize(writer, order, xmlns);
                    return writer.ToString();
                }                               
            }
        }

        //https://stackoverflow.com/questions/3871738/force-xdocument-to-write-to-string-with-utf-8-encoding
        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding { get { return Encoding.UTF8; } }
        }
    }
}
