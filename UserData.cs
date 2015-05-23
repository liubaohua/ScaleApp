using System;
using System.Collections.Generic;

using System.Text;


namespace Print
{
    public class UserData
    {
        public String ElementName { get; set; }
        public String NodeName { get; set; }
        public List<NameValuePair> ValueList { get; set; }

    }

    public class NameValuePair
    {
        public String Name { get; set; }
        public String Value { get; set; }
    }
}
