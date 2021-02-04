using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace kpmg.Controllers
{
    [EnableCors("Cors")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<People> Get()
        {
            using (var db = new EmployersContext())
            {
                return db.People.Where(person => 
                    person.Birthday.Value.Day == DateTime.Now.AddDays(1).Day ||
                    person.Birthday.Value.Day == DateTime.Now.AddDays(2).Day ||
                    person.Birthday.Value.Day == DateTime.Now.AddDays(3).Day)
                    .ToList();
            }
        }
    }
}
