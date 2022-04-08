using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public interface IQueuePatients
    {
        public void PatientCome(Patient patient);
        public void PatientPerformance();
    }
}