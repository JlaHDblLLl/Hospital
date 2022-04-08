using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class PatientCardHandler
    {
        public IRepository<PatientCard> patientCards;

        public PatientCardHandler(PatientCard card)
        {
            patientCards.Insert(card);
        }
    }
}