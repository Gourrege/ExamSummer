using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSummer
{
    public class Patient
    {
        
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Surname} - {ContactNumber}";
        }
    }

    public class PatientData : DbContext
    {
        public PatientData() : base("OODExam_HenrickGourrege") { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


    }
}
