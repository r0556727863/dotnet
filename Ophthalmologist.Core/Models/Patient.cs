using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Appointment> Appointments { get; set; }

        // public DateOnly BirthDate { get; set; }
        // public List<string> MedicalHistory { get; set; }
        //public List<Appointment> Appointments { get; set; }

        public Patient()
        {
            
        }

        public Patient(int id, string name,int age, List<Appointment> appointments/*, DateOnly birthDate*//*, List<string> medicalHistory*/)
        {
            Id = id;
            Name = name;
            Age = age;
            Appointments = appointments;
            //BirthDate = birthDate;
            // MedicalHistory = medicalHistory;
        }
    }
}
