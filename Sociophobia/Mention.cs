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
    public class Mention
    {
        [XmlElement("Username")]
        public String Username
        {
            get;
            private set;
        }

        [XmlElement("Tweet")]
        public String Tweet
        {
            get;
            private set;
        }

        public Mention(String username, String tweet)
        {
            Username = username;
            Tweet = tweet;
        }

        public Mention(SerializationInfo info, StreamingContext context)
        {
            Username = (String)info.GetValue("Username", typeof(String));
            Tweet = (String)info.GetValue("Tweet", typeof(String));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Username", Username);
            info.AddValue("Tweet", Tweet);
        }
    }
}
