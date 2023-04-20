using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    public partial class AllowOrChargesFix
    {
        [XmlElement("ALLOW_OR_CHARGE")]
        public List<AllowOrCharge> AllowOrCharge = new ();

        [XmlElement("ALLOW_OR_CHARGES_TOTAL_AMOUNT")]
        public decimal AllowOrChargesTotalAmount;
    }
}
