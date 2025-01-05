using Ophthalmologist.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Repositories
{
    public interface IDoctorRepository
    {
        List<Doctor> GetList();
        Doctor SearchId(int id);
        void AddVal(Doctor doctor);
        void PutVal(int id, Doctor doctor);
        void DeleteVal(int id);
    }
}
