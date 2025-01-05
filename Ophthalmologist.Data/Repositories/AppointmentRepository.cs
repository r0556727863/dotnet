using Ophthalmologist.Core.Models;
using Ophthalmologist.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Data.Repositories
{
    public class AppointmentRepository:IAppointmentRepository
    {
        private readonly DataContext _context;
        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }
        public List<Appointment> GetList()
        {
            return _context.Appointments.ToList();
        }

        public Appointment SearchId(int id)
        {
            foreach (var appointment in _context.Appointments)
            {
                if (appointment.Id == id)
                    return appointment;
            }
            return new Appointment();
        }

        public void AddVal(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
        }

        public void PutVal(int id, Appointment appointment)
        {
            for (int i = 0; i < _context.Appointments.ToList().Count; i++)
            {
                if (_context.Appointments.ToList()[i].Id == id)
                {
                    _context.Appointments.ToList()[i] = appointment;
                    return;
                }
            }
        }

        public void DeleteVal(int id)
        {
            foreach (var appointment in _context.Appointments)
            {
                if (appointment.Id == id)
                    _context.Appointments.Remove(appointment);
                return;
            }
        }
    }
}
