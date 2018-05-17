using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_CantThinkOfAnotherName.Controllers {
    public static class Count {
        public static int dracula = 0;
    }

    public static class NamesList {
        public static List<string> Names = new List<string>();
    }

    public class ValuesController : ApiController {
        // GET api/values
        public string Get() {

            string output = "";

            foreach(var name in NamesList.Names) {
                output += name + "\n";

            }

            return output;
        }

        // GET api/values/5
        public string Get(string name) {
            NamesList.Names.Add(name);
            return name + " added to the names list";
        }

        // POST api/values
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        public void Delete(int id) {
        }
    }
}
