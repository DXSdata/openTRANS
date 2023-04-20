using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class FTSynonyms
    {
        [XmlElement("SYNONYM", Namespace = Namespace.bmecat)]
        public List<string> Synonym = new ();
    }
}