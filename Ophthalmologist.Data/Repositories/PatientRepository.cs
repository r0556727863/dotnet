using Ophthalmologist.Core.Models;
using Ophthalmologist.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Data.Repositories
{
    public class PatientRepository:IPatientRepository
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext context)
        {
            _context = context;
        }
        public List<Patient> GetList()
        {
            return _context.Patients.ToList();
        }

        public Patient SearchId(int id)
        {
            foreach (var patient in _context.Patients)
            {
                if (patient.Id == id)
                    return patient;
            }
            return new Patient();
        }

        public void AddVal(Patient patient)
        {
            _context.Patients.Add(patient);
        }

        public void PutVal(int id, Patient patient)
        {
            for (int i = 0; i < _context.Patients.ToList().Count; i++)
            {
                if (_context.Patients.ToList()[i].Id == id)
                {
                    _context.Patients.ToList()[i] = patient;
                    return;
                }
            }
        }

        public void DeleteVal(int id)
        {
            foreach (var patient in _context.Patients)
            {
                if (patient.Id == id)
                    _context.Patients.Remove(patient);
                return;
            }
        }
    }
}
