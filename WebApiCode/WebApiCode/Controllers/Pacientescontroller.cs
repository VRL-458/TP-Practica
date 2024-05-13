using LNAT.businesslogic.Managers;
using LNAT.businesslogic.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pacientescontroller : ControllerBase
    {
        private readonly PacientesManagers _managerPatients;
        public Pacientescontroller(PacientesManagers pacientemanager)
        {
            _managerPatients = pacientemanager;
        }
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
            
            return $"{nombre[0]}{apellido[0]}{ci}";
        }
        // POST api/<Pacientescontroller>
        [HttpPost]
        public void Post([FromBody] pacientes value)
        {
            Console.WriteLine("llegamos");
            _managerPatients.CrearCodepacientes(value);
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
