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
            // 1. По чем искать проблему?
            // 2. Как выбрать именно то действие, которое нам нужно
            // 3. Правильно ли все?)
            var action = Employees.Find();
            
        }
        public EmployeeAction(Employee employee, PatientCard patientCard)
        {
            PatientCard = patientCard;
            Employee = employee; 
        }
    }
}