using Microsoft.AspNetCore.Mvc;
using Ophthalmologist.Core.Models;
using Ophthalmologist.Core.Services;
using Ophthalmologist.Service;
using static System.Reflection.Metadata.BlobBuilder;
//using Ophthalmologist.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ophthalmologist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
      

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _doctorService.GetAll();
        }

        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return _doctorService.GetById(id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
            _doctorService.AddValue(doctor);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor doctor)
        {
            _doctorService.PutValue(id, doctor);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _doctorService.Delete(id);
        }
    }
    
}
