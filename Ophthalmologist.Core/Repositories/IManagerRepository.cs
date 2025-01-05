using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Repositories
{
    public interface IManagerRepository
    {
        IDoctorRepository Doctor { get; }
        IPatientRepository Patient { get; }
        IAppointmentRepository Appointment { get; }

        void Save();
    }
}
