using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class DutyDoctor : Employee
    {
        public Adress AdressOfWork { get; set; }
        public DutyDoctor(string name, Adress adress, IRepository<ActionWithPatient> actions) : base(name, actions)
        {
            this.AdressOfWork = adress;
        }
    }
}