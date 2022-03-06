using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class PatientCardController
    {
        List<PatientCard> patientCards = new List<PatientCard>();

        public PatientCardController(PatientCard card)
        {
            patientCards.Add(card);
        }
    }
}