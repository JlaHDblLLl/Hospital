using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Reception : IQueuePatients
    {
        Queue<Patient> Patients = new Queue<Patient>();
        public void PatientCome(Patient patient)
        {
            Patients.Enqueue(patient);
        }
        public void PatientDistribution()
        {
            Patient patient = Patients.Dequeue();
            // можно сделать реализацию с помощью LINQ и базы данных адрессов


        }
    }
}