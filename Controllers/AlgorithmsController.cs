using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace algorithmApi.Controllers {
    [Route ("algorithms/")]
    [ApiController]
    public class AlgorithmsController : ControllerBase {
        problems euler;
        public AlgorithmsController() {
            Console.WriteLine("hello");
            euler = new problems();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get () {
            return new string[] { "value1", "value2" };
        }

        // GET algorithms
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST algorithms/HelloWorld
        [HttpGet("ProblemOne")]
        public ActionResult<string> HelloWorld () {
            string probelm1 = "Problem One: " + euler.problem1();
            return probelm1;
        }

        // PUT algorithms/{id}
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}