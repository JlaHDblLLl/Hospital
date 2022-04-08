using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Record
    {
        public int Id { get; set; }
        public string Diagnose { get; set; }
        public string Comment { get; set; }
        public Record(int id, string diagnose, string comment)
        {
            Id = id;
            Diagnose = diagnose;
            Comment = comment;
        }
    }
}