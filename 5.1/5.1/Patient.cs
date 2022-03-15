using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerName { get; set; }
        public Adress Adress { get; set; }

        public Patient(int id, string name, string serName, Adress adress)
        {
            Id = id;
            Name = name;
            SerName = serName;
            Adress = adress;
        }
    }
}