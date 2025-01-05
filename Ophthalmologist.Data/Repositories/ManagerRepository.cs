using Ophthalmologist.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Data.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly DataContext _context;
        public IDoctorRepository Doctor { get; }
        public IPatientRepository Patient { get; }
        public IAppointmentRepository Appointment { get; }

        public ManagerRepository(DataContext context, IDoctorRepository doctorRepository, IPatientRepository patients, IAppointmentRepository appointments)
        {
            _context = context;
            Doctor = doctorRepository;
            Patient = patients;
            Appointment = appointments;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}