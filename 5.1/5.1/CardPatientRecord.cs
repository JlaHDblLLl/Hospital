using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class CardPatientRecord
    {
        public void InsertRecord(PatientCard patientCard, Record record)
        {
            patientCard.Records.Insert(record);
        }
        public Record GetRecord(PatientCard patientCard, Record record)
        {
            return patientCard.Records.Get();
        }

    }
}