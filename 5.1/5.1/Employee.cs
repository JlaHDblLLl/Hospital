using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Employee
    {
        // еще ГлавВрач, медсестра, Дежурный
        public string Name { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }


    }
}