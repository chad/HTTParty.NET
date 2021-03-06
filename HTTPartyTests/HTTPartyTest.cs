﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using httparty;

namespace HTTPartyTests
{
    [TestFixture]
    public class HTTPartyTest
    {
        [Test]
        public void CallToGetReturnsHTTPartyResponseObject() 
        {
            Assert.That(httparty.Party.Get("http://foo.com"), Is.InstanceOf(typeof(httparty.Response)));
        }
    }

    [TestFixture]
    public class ResponseTest
    {
        [Test]
        public void CanReturnRawResponseBody()
        {
            Response response = new Response("raw body", new Headers());
            Assert.That("raw body", Is.EqualTo(response.Body));
        }
    }
}
