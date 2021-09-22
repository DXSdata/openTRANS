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


        public OrderResponse Result
        {
            get
            {
                var serializer = new XmlSerializer(typeof(OrderResponse));
                OrderResponse orderResponse;

                using (TextReader reader = new StringReader(this.orderResponse))
                {
                    orderResponse = (OrderResponse)serializer.Deserialize(reader);
                }
                return orderResponse;
            }
        }

    }
}
