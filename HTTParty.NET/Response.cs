using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace httparty
{
    public class Response
    {
        string body;
        public string Body
        {
            get
            {
                return body;
            }
        }
        Headers headers;
        public Response(string body, Headers headers)
        {
            this.body = body;
            this.headers = headers;
        }
    }
}
