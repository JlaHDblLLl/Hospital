using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class PatientCardHandler
    {
        public IRepository<PatientCard> patientCards;

        public PatientCardHandler(IRepository<PatientCard> cards)
        {
            patientCards = cards;
        }
    }
}