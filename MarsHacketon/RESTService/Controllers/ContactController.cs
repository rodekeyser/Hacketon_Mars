using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTService.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Temperature", "WindSpeed", "WindOrientation", "ParticleSize", "TimeStamp" };
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
    }
}
