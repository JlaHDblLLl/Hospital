using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Redirect : ActionWithPatient
    {

        public override void Do(PatientCard patientCard, EmployeeHandler employeeHandler)
        {
            base.Do(patientCard, employeeHandler);
            Record record = new Record(base.Comment);
            patientCard.Records.Insert(record);
            Patient patient = patientCard.Patient;
            Console.WriteLine("Кому вы хотите перевести пациента?");
            int i = 0;
            foreach (var item in base.EmployeeHandler.Employees.GetAll())
            {
                i++;
                Console.WriteLine($"{i} : {item}");
            }
            int choise = Convert.ToInt32(Console.ReadLine()) - 1;

            var doctor = EmployeeHandler.Employees.Get(choise);
            if (doctor != null)
            {
                EmployeeAction employeeAction = new EmployeeAction(doctor, patientCard, employeeHandler);
            }
        }

    }
}