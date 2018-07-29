using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    public class BodyTypesController : Controller
    {
        [HttpPost]
        [Route("api/BodyTypes/JsonStringBody")]
        public IActionResult JsonStringBody([FromBody] Message content)
        {
            return Json(content);
        }
    }

    public class Message{
        public string message { get; set; }
    }
    /* 
        [Route("api/[controller]")]
        [ApiController]
        public class ValuesController : ControllerBase
        {
            // GET api/values
            [HttpGet]
            public ActionResult<IEnumerable<string>> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET api/values/5
            [HttpGet("{id}")]
            public ActionResult<string> Get(int id)
            {
                return "value";
            }

            // POST api/values
            [HttpPost]
            public ActionResult<string> Post([FromBody] string value)
            {
                var laman = "Hello";
                return laman;
            }

            // PUT api/values/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
        */
}
