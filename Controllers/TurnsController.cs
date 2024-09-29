using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnsController : ControllerBase
    {
        private static new List<Turn> turns = new List<Turn>
        {
            new Turn("Rozovsky",new DateTime(),new DateTime(),3,new DateTime(),new DateTime(),235),
            new Turn("Office",new DateTime(),new DateTime(),2,new DateTime(),new DateTime(),198),
            new Turn("Shlomo Hacohen",new DateTime(),new DateTime(),5,new DateTime(),new DateTime(),456)           
        };

        // GET: api/<TurnsController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return turns;
        }

        // GET api/<TurnsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var index = turns.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            return index;
        }

        // POST api/<TurnsController>
        [HttpPost]
        public void Post([FromBody] Turn value)
        {
            turns.Add(value);
        }

        // PUT api/<TurnsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn value)
        {
            var index = clinics.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            turns[index].ClinicName = value.ClinicName;
            turns[index].StartHour = value.StartHour;
            turns[index].EndHour = value.EndHour;
            turns[index].Day = value.Day;
            turns[index].DateStart = value.DateStart;
            turns[index].DateEnd = value.DateEnd;
            turns[index].TenantCode = value.TenantCode;        
        }

        // DELETE api/<TurnsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = turns.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            turns.Remove(turns[index]);
        }
    }
}
