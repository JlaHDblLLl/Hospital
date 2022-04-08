using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class PatientCard
    {
        public int Id { get; set; }
        public IRepository<Record> Records;
        public Patient Patient { get; set; }
        public PatientCard(int id, Patient patient)
        {
            this.Id = id;
            this.Patient = patient;
        }
    }
}