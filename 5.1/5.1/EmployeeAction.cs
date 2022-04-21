using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class EmployeeAction 
    {
        EmployeeHandler EmployeeHandler { get; set; }
        PatientCard PatientCard { get; set; }
        Employee Employee { get; set; }

        public void PatientPerformance()
        {
            Console.WriteLine("Введите действие которое хотите сделать с пациентом: ");
            int i = 0;
            foreach (var item in Employee.Actions.GetAll())
            {
                i++;
                Console.WriteLine($"{i} : {item}");
            }

            int choise = Convert.ToInt32(Console.ReadLine()) - 1;

            Employee.Actions.Get(choise).Do(this.PatientCard, EmployeeHandler);

        }
        public EmployeeAction(Employee employee, PatientCard patientCard, EmployeeHandler employeeHandler)
        {
            this.EmployeeHandler = employeeHandler;
            this.PatientCard = patientCard;
            this.Employee = employee;
            PatientPerformance();
        }
    }
}