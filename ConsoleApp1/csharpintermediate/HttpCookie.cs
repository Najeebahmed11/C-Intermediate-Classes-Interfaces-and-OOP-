using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dict;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dict = new Dictionary<string, string>();

        }
        public string this[string key]
        {
            get { return _dict[key]; }
            set { _dict[key] = value; }

        }
    }
}
