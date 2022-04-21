using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Heal : ActionWithPatient
    {
        public override void Do(PatientCard patientCard, EmployeeHandler employeeHandler)
        {
            base.Do(patientCard, employeeHandler);
        }
    }
}