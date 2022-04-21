using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Reception : IQueuePatients
    {
        Queue<Patient> QPatients = new Queue<Patient>();
        PatientCardHandler PatientCardHandler { get; set; }
        EmployeeHandler EmployeeConteiner { get; set; }
        public void PatientCome(Patient patient)
        {
            QPatients.Enqueue(patient);
        }
        public void PatientPerformance()
        {
            Patient patient = QPatients.Dequeue();
            var card = PatientCardHandler.patientCards.Find(card => card.Patient.Name == patient.Name && card.Patient.SerName == patient.SerName);
            if (card != null)
            {
                var doctor = EmployeeConteiner.Employees.GetAll().OfType<DutyDoctor>().FirstOrDefault(d => d.AdressOfWork.Street == card.Patient.Adress.Street);
                if (doctor != null)
                {
                    EmployeeAction employeeAction = new EmployeeAction(doctor, card, EmployeeConteiner);
                } 
            }
        }
        public Reception(PatientCardHandler patientCardHandler, EmployeeHandler employeeHandler)
        {
            this.PatientCardHandler = patientCardHandler;
            this.EmployeeConteiner = employeeHandler;
        }
        public Reception(PatientCardHandler patientCardHandler, EmployeeHandler employeeHandler, Queue<Patient> patients)
        {
            this.QPatients = patients;
            this.PatientCardHandler = patientCardHandler;
            this.EmployeeConteiner = employeeHandler;
        }
    }
}