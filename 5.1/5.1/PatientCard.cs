using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class PatientCard
    {
        public IRepository<Record> Records;
        Patient Patient { get; set; }
        public PatientCard(Patient patient)
        {
            this.Patient = patient;
        }
    }
}