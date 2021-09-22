using System;
using System.Xml.Serialization;

namespace openTRANS
{
    public class FTVersion
    {
        [XmlElement("VERSION", Namespace = Common.Namespace.bmecat)]
        public string Version;

        [XmlElement("VERSION_DATE", Namespace = Common.Namespace.bmecat)]
        public DateTime VersionDate;

        [XmlElement("REVISION", Namespace = Common.Namespace.bmecat)]
        public string Revision;

        [XmlElement("REVISION_DATE", Namespace = Common.Namespace.bmecat)]
        public DateTime RevisionDate;

        [XmlElement("ORIGINAL_DATE", Namespace = Common.Namespace.bmecat)]
        public DateTime OriginalDate;
    }
}