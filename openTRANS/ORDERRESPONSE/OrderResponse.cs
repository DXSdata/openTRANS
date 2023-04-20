﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace openTRANS
{
    [Serializable]
    [XmlRoot("ORDERRESPONSE", Namespace = "http://www.opentrans.org/XMLSchema/2.1", IsNullable = false)]
    public partial class OrderResponse
    {
        [XmlAttribute("version")]
        public string Version = "2.1";

        [XmlElement("ORDERRESPONSE_HEADER")]
        public OrderResponseHeader OrderResponseHeader = new ();

        [XmlArray("ORDERRESPONSE_ITEM_LIST")]
        [XmlArrayItem("ORDERRESPONSE_ITEM")]
        public List<OrderResponseItem> OrderResponseItemList = new ();

        [XmlElement("ORDERRESPONSE_SUMMARY")]
        public OrderResponseSummary OrderResponseSummary
        {
            get => new (this);
            set { }
        }
    }
}