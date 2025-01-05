using Ophthalmologist.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Repositories
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetList();
        Appointment SearchId(int id);
        void AddVal(Appointment appointment);
        void PutVal(int id, Appointment appointment);
        void DeleteVal(int id);
    }
}
