using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.API
{
    [TestFixture]
    public class GET
    {
        [Test]
        public void GetBasicMethod()
        {
            var client = new RestClient("http://localhost:3000/");
            var request = new RestRequest("post/{postid}",Method.GET);
            request.AddUrlSegment("postid", "1");
        }


    }
}
