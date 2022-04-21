using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class MainDoctor : Employee
    {
        public MainDoctor(string name, IRepository<ActionWithPatient> actions) : base(name, actions)
        {
        }
    }
}