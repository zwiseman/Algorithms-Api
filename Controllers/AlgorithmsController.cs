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

        // GET algorithms
        [HttpGet]
        public ActionResult<string> Get () {
            return "It's Up, Navigate to ...";
        }

        // GET algorithms
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST algorithms/ProjectEuler
        [HttpGet("ProjectEuler")]
        public ActionResult<int []> HelloWorld () {
            return euler.getProblems();
        }

        // PUT algorithms/{id}
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE algorithms/{id}
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}