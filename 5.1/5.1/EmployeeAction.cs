using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class EmployeeAction : IQueuePatients
    {
        Queue<Patient> Patients = new Queue<Patient>();
        Employee Employee { get; set; }
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
        public EmployeeAction(Employee employee)
        {
            Employee = employee; 
        }
    }
}