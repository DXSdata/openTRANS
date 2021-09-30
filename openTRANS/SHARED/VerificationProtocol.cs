using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS {
    public class VerificationProtocol {
        [XmlElement("RESULT_CODE")]
        public string ResultCode { get; set; }

        [XmlElement("RESULT_DESCR")]
        public List<string> ResultDescr { get; set; }
    }
}