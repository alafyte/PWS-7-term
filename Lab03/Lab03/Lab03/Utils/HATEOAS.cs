using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab03.Utils
{
    public class HATEOAS
    {
        public string Href { get; set; }
        public string Rel { get; set; }
        public string Method { get; set; }

        public HATEOAS(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }
    }
}