using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class DutyDoctor : Employee
    {
        IEnumerable<ActionWithPatient> Actions;
        public DutyDoctor(string name, IEnumerable<ActionWithPatient> action) : base(name)
        {
            this.Actions = action;
        }
    }
}