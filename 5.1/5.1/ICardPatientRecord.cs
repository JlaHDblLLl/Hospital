using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public interface ICardPatientRecord
    {
        public void InsertRecord(PatientCard patientCard, Record record);
        public Record GetRecord(PatientCard patientCard);

    }
}