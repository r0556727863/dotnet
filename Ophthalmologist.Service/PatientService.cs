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
    public class PatientService:IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public List<Patient> GetAll()
        {
            return _patientRepository.GetList();
        }
        public Patient GetById(int id)
        {
            return _patientRepository.SearchId(id);
        }
        public void AddValue(Patient patient)
        {
            _patientRepository.AddVal(patient);
        }
        public void PutValue(int id, Patient patient)
        {
            _patientRepository.PutVal(id, patient);
        }
        public void Delete(int id)
        {
            _patientRepository.DeleteVal(id);
        }
    }
}
