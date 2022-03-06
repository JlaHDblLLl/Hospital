﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class CardPatientRecord
    {
        public Patient Patient { get; set; }
        public string Diagnose { get; set; }
        public string Comment { get; set; }
        
        public CardPatientRecord(Patient patient, string diagnose, string comment)
        {
            Patient = patient;
            Diagnose = diagnose;
            Comment = comment;
        }


    }
}