using Ophthalmologist.Core.Models;
using Ophthalmologist.Core.Repositories;
using Ophthalmologist.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Service
{
    public class AppointmentService:IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public List<Appointment> GetAll()
        {
            return _appointmentRepository.GetList();
        }
        public Appointment GetById(int id)
        {
            return _appointmentRepository.SearchId(id);
        }
        public void AddValue(Appointment appointment)
        {
            _appointmentRepository.AddVal(appointment);
        }
        public void PutValue(int id, Appointment appointment)
        {
            _appointmentRepository.PutVal(id,appointment);
        }
        public void Delete(int id)
        {
            _appointmentRepository.DeleteVal(id);
        }
    }
}
