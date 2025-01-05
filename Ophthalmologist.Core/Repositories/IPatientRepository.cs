using Ophthalmologist.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> GetList();
        Patient SearchId(int id);
        void AddVal(Patient patient);
        void PutVal(int id, Patient patient);
        void DeleteVal(int id);
    }
}
