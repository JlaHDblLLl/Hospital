using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class WriteOut : ActionWithPatient
    {

        public override void Do(PatientCard patientCard, EmployeeHandler employeeHandler)
        {
            base.Do(patientCard, employeeHandler);
            Console.WriteLine("Введите диагноз:");
            string Diagnose = Console.ReadLine();
            Record record = new Record(Diagnose, base.Comment);
            patientCard.Records.Insert(record);
        }
    }
}