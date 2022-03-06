using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class PatientsController
    {
        List<Patient> patients = new List<Patient>();

        public PatientsController(Patient patient)
        {
            patients.Add(patient);
        }
    }
}