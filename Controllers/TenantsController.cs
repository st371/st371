using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private static new List<Tenant> tenants = new List<Tenant>
        {
            new  Tenant("Yakov","Cohen","231315156","0556745532","yc745532@gmail.com")
            new  Tenant("ysrael meir","galin","223122432","0548554534","yg8554534@gmail.com")
            new  Tenant("david","lev","234444156","0556778990","dl6778990@gmail.com")
        }
        // GET: api/<TenantsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return tenants;
        }

        // GET api/<TenantsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var index = tenants.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            return index;
        }

        // POST api/<TenantsController>
        [HttpPost]
        public void Post([FromBody] Tenant value)
        {
            tenants.Add(value);
        }

        // PUT api/<TenantsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            public void Put(int id, [FromBody] Clinic value)
            {
                var index = tanents.FindIndex(e => e.Id == id);
                if (index == -1)
                    return NotFound();
                tanents[index].FirstName = value.FirstName;
                tanents[index].LastName = value.LastName;
                tanents[index].Id = value.Id;
                tanents[index].Phone = value.Phone;
                tanents[index].EmailAddress = value.EmailAddress;

            }        }

        // DELETE api/<TenantsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = tanents.FindIndex(e => e.Id == id);
            if (index == -1)
                return NotFound();
            tanents.Remove(tanents[index]);
        }
    }
}
z        