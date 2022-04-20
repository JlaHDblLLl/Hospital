using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class EmployeeAction 
    {
        PatientCard PatientCard { get; set; }
        Employee Employee { get; set; }

        public void PatientPerformance()
        {
            Console.WriteLine("Введите действие которое хотите сделать с пациентом: ");
            foreach (var item in Employee.Actions.GetAll())
            {
                Console.WriteLine($"{item.ID} : {item}");
            }

            int choise = Convert.ToInt32(Console.ReadLine()) - 49;

            Employee.Actions.Find(action => choise == action.ID).Do(this.PatientCard);

        }
        public EmployeeAction(Employee employee, PatientCard patientCard)
        {
            PatientCard = patientCard;
            Employee = employee; 
        }
    }
}