﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]News value)
        {
            var v = value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]News value)
        {
            var v = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
