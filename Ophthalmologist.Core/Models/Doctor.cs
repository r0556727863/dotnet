﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophthalmologist.Core.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public List<Appointment> Appointments { get; set; }

        public Doctor()
        {
            
        }

        public Doctor(int id, string name, int experience, List<Appointment> appointments)
        {
            Id = id;
            Name = name;
            Experience = experience;
            Appointments = appointments;
        }
    }
}
