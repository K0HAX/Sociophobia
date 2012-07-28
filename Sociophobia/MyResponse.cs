using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Sociophobia
{
    [XmlRoot("MyResponse")]
    class MyResponse
    {
        [XmlElement("startIndex", Order = 1)]
        public int StartIndex { get; set; }

        [XmlElement("Mention", Order = 2)]
        public List<MentionCollection> Mentions { get; set; }

        public MyResponse()
        {
            Mentions = new List<MentionCollection>();
        }
    }
}
