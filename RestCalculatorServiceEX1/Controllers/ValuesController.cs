using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestCalculatorServiceEX1.Model;

namespace RestCalculatorServiceEX1.Controllers
{
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
        public ActionResult<int> Get(int id)
        {
            return id;
        }

        // POST api/values
        [HttpPost("Add", Name = "Add")]
        public int Post([FromBody] Data data)
        {
            return data.A + data.B;
        }

        [HttpPost("Sub", Name = "Sub")]
        public int Sub([FromBody] Data data)
        {
            return data.A - data.B;
        }
        [HttpPost("Multi", Name = "Multi")]
        public int Multi([FromBody] Data data)
        {
            return data.A * data.B;
        }
        [HttpPost("Div", Name = "Div")]
        public int Div([FromBody] Data data)
        {
            return data.A / data.B;
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
}
