using Ophthalmologist.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Services
{
    public interface IPatientService
    {
        List<Patient> GetAll();
        Patient GetById(int id);
        void AddValue(Patient value);
        void PutValue(int id, Patient value);
        void Delete(int id);
    }
}
