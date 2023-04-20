using System;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class MimeInfo
    {
        [XmlElement("MIME")]
        public Mime Mime = new ();
    }
}