using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public class SubPackages {
        [XmlElement("PACKAGE")]
        public List<Package> Package { get; set; }
    }
}