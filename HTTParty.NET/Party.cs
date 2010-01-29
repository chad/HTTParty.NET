using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace httparty
{
    public class Party
    {
        public static Response Get(string url)
        {
            return new Response("", new Headers());
        }
    }
}
