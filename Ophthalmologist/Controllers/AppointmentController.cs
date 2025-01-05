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
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }


        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return _appointmentService.GetAll();
        }

        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return _appointmentService.GetById(id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Appointment appointment)
        {
            _appointmentService.AddValue(appointment);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment appointment)
        {
            _appointmentService.PutValue(id, appointment);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _appointmentService.Delete(id);
        }
    }
}
