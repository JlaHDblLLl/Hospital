using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Employee
    {
        public string Name { get; set; }
        public IRepository<ActionWithPatient> Actions { get; set; }

        public Employee(string name, IRepository<ActionWithPatient> repository)
        {
            this.Actions = repository;
            this.Name = name;
        }
    }
}