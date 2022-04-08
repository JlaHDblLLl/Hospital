using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class ActionWithPatient
    {
        ICardPatientRecord CardPatientRecord;
        //PatientCardHandler PatientCardHandler { get; set; }
        public virtual void Do(PatientCard patientCard)
        {
            //реализация добавления в определенную карту с определенным пациентом
        }

        //public ActionWithPatient(PatientCardHandler patientCardHandler)
        //{
        //    PatientCardHandler = patientCardHandler;
        //}
    }
}