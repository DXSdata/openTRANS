using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public class FTSynonyms
    {
        [XmlElement("SYNONYM", Namespace = Namespace.bmecat)]
        public List<string> Synonym = new List<string>();
    }
}