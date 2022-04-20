using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class DutyDoctor : Employee
    {
        public Adress AdressOfWork { get; set; }
        IEnumerable<ActionWithPatient> Actions { get; set; }
        public DutyDoctor(string name, Adress adress, IEnumerable<ActionWithPatient> action) : base(name)
        {
            this.AdressOfWork = adress;
            this.Actions = action;
        }
    }
}