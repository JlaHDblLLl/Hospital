using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Employee : IQueuePatients
    {
        Queue<Patient> Patients = new Queue<Patient>();
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }

        public void PatientCome(Patient patient)
        {
            Patients.Enqueue(patient);
        }

        public void PatientDistribution()
        {
            while (Patients.Count > 0)
            {
                Patient patient = Patients.Dequeue();
                // определить что с ним делать(можно метод в отдельном классе)
            }
        }
    }
}