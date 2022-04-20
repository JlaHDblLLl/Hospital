using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Redirect : ActionWithPatient
    {

        public override void Do(PatientCard patientCard)
        {
            base.Do(patientCard);
            Record record = new Record(base.Comment);
            patientCard.Records.Insert(record);
            Patient patient = patientCard.Patient;
            Console.WriteLine("Кому вы хотите перевести пациента?"); //вводить ли EmployeeConteiner? как решить по-другому
            string chose = Console.ReadLine();

            switch (chose)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }

            var doctor = EmployeeConteiner.Employees.GetAll().OfType<DutyDoctor>().FirstOrDefault(d => d.AdressOfWork == patientCard.Patient.Adress);
            if (doctor != null)
            {
                EmployeeAction employeeAction = new EmployeeAction(doctor, patientCard);
            }
        }

        public Redirect(int id) : base(id)
        {
        }
    }
}