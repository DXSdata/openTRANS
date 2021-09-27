using System.IO;
using System.Xml.Serialization;

namespace openTRANS
{
    public class XmlReader
    {
        private string orderResponse;


        public XmlReader(string orderResponse)
        {
            this.orderResponse = orderResponse;
        }


        public Orderresponse Result
        {
            get
            {
                var serializer = new XmlSerializer(typeof(Orderresponse));
                Orderresponse orderResponse;

                using (TextReader reader = new StringReader(this.orderResponse))
                {
                    orderResponse = (Orderresponse)serializer.Deserialize(reader);
                }
                return orderResponse;
            }
        }

    }
}
