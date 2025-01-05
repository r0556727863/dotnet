using Microsoft.AspNetCore.Mvc;
using Ophthalmologist.Core.Models;
using Ophthalmologist.Core.Services;

//using Ophthalmologist.Entities;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ophthalmologist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
          private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }


        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _patientService.GetAll();
        }

        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return _patientService.GetById(id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            _patientService.AddValue(patient);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient patient)
        {
            _patientService.PutValue(id,patient);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _patientService.Delete(id);
        }
    }
}
