using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infraestructure;
using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private IServiceDomain _serviceDomain;

        public ServiceController(IServiceDomain serviceDomain)
        {
            _serviceDomain = serviceDomain;
        }
        
        // GET: api/Service
        [HttpGet(Name = "GetTutorials")]
        public List<Service> Get()
        {

            return _serviceDomain.GetAll();

        }

        // GET: api/Service/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Service
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Service/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Service/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
