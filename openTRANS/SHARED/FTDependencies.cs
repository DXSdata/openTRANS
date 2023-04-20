using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    [Serializable]
    public partial class FTDependencies
    {
        [XmlElement("FT_IDREF", Namespace = Namespace.bmecat)]
        public List<string> FTIdRef = new ();
    }
}