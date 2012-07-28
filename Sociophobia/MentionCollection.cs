using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sociophobia
{
    
    public class MentionCollection
    {
        [XmlElement("startIndex", Order = 1)]
        public int StartIndex { get; set; }

        [XmlElement("MentionCollection", Order = 1)]
        public List<Mention> Mentions { get; set; }

        [XmlAttribute()]
        public string MyAttribute { get; set; }
        
        public MentionCollection()
        {
            this.MyAttribute = "MentionCollection";
        }
    }
}
