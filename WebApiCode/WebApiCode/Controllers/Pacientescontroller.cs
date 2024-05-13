
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pacientescontroller : ControllerBase
    {
        
        // GET: api/<Pacientescontroller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Pacientescontroller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet("{nombre}/{apellido}/{ci}")]
        public string Get(string nombre, string apellido, string ci)
        {
            //como al hacer el get, ya se tiene controlado en formato string desde la api2, aqui no hay que controlar nada y seria inecesario
            return $"{nombre[0]}{apellido[0]}{ci}";
        }
        // POST api/<Pacientescontroller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
          
        }

        // PUT api/<Pacientescontroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Pacientescontroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
