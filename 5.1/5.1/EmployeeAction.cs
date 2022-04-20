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
            for (int i = 0; i < Employee.Actions.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Employee.Actions[i]}");
            }
            string choise = Console.ReadLine();

            Employee.Actions[Convert.ToInt32(choise)].Do(this.PatientCard);

        }
        public EmployeeAction(Employee employee, PatientCard patientCard)
        {
            PatientCard = patientCard;
            Employee = employee; 
        }
    }
}