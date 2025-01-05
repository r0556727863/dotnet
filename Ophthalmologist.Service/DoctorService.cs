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
    public class DoctorService:IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public List<Doctor>GetAll()
        {
            return _doctorRepository.GetList();
        }
        public Doctor GetById(int id)
        {
            return _doctorRepository.SearchId(id);
        }
        public void AddValue(Doctor doctor)
        {
            _doctorRepository.AddVal(doctor);
        }
        public void PutValue(int id, Doctor doctor)
        {
            _doctorRepository.PutVal(id, doctor);
        }
        public void Delete(int id)
        {
            _doctorRepository.DeleteVal(id);
        }
    }
}
