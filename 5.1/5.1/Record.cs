using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Record
    {
        public string Diagnose { get; set; }
        public string Comment { get; set; }
        public Record(Patient patient, string diagnose, string comment)
        {
            Diagnose = diagnose;
            Comment = comment;
        }
    }
}