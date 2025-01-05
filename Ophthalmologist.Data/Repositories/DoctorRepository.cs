
using Microsoft.EntityFrameworkCore;
using Ophthalmologist.Core.Models;
using Ophthalmologist.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Data.Repositories
{
    public class DoctorRepository:IDoctorRepository
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context)
        {
            _context = context;
        }

        public List<Doctor>GetList()
        {
            return _context.Doctors.ToList();
        }

        public Doctor SearchId(int id)
        {
            foreach (var doctor in _context.Doctors)
            {
                if (doctor.Id == id)
                    return doctor;
            }
            return new Doctor();
        }

        public void AddVal(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
        }

        public void PutVal(int id,Doctor doctor)
        {
            for (int i = 0; i < _context.Doctors.ToList().Count; i++)
            {
                if (_context.Doctors.ToList()[i].Id == id)
                {
                    _context.Doctors.ToList()[i] = doctor;
                    return;
                }
            }
        }

        public void DeleteVal(int id)
        {
            foreach (var doctor in _context.Doctors)
            {
                if (doctor.Id == id)
                    _context.Doctors.Remove(doctor);
                return;
            }
        }
    }
}
