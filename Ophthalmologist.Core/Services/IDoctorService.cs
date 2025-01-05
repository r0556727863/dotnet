using Ophthalmologist.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Services
{
    public interface IDoctorService
    {
        List<Doctor> GetAll();
        Doctor GetById(int id);
        void AddValue(Doctor value);
        void PutValue(int id, Doctor value);
        void Delete(int id);

    }
}
