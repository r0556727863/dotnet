using Ophthalmologist.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        Appointment GetById(int id);
        void AddValue(Appointment value);
        void PutValue(int id, Appointment value);
        void Delete(int id);
    }
}
