using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {

        private static new List<Clinic> clinics = new List<Clinic>
        {
            new Clinic{ "Office", "Rozovsky 10", 50},
            new Clinic{ "Home", "Shlomo Hacohen", 30},
            new Clinic{ "Shlomo Hacohen", "Shlomo Hacohen", 30}           
        };

        // GET: api/<ClinicsController>
        [HttpGet]
        public IEnumerable<Clinic> Get()
        {
            return clinics;
        }

        // GET api/<ClinicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var index = clinics.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            return index;
        }

        // POST api/<ClinicsController>
        [HttpPost]
        public void Post([FromBody] Clinic value)
        {
            clinics.Add(value);
        }

        // PUT api/<ClinicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Clinic value)
        {
            var index = clinics.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            clinics[index].ClinicName = value.ClinicName;
            clinics[index].ClinicAdress = value.ClinicAdress;
            clinics[index].CostForHour = value.CostForHour;
        }

        // DELETE api/<ClinicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = clinics.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            clinics.Remove(clinics[index]);
        }
    }
}
