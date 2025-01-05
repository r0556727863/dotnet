using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor doctor { get; set; }
        // public DateTime AppointmentTime { get; set; }
        public bool Status { get; set; }

        public Appointment()
        {

        }

        public Appointment(int id, Patient patient, Doctor doctor, int doctorId, int patientId, bool status/*DateTime appointmentTime,*/)
        {
            Id = id;
            this.patient = patient;
            this.doctor = doctor;
            // AppointmentTime = appointmentTime;
            Status = status;
            DoctorId = doctorId;
            PatientId = patientId;
        }
    }
    
}
