using Microsoft.AspNetCore.Mvc;

namespace SF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController : ControllerBase
    {
        // GET: api/<InstituicaoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InstituicaoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InstituicaoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InstituicaoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InstituicaoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
