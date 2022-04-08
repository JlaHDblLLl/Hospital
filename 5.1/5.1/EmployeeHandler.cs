using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class EmployeeHandler
    {
        public IRepository<Employee> Employees { get; set; }
        public EmployeeHandler(IRepository<Employee> repository)
        {
            this.Employees = repository;
        }
    }
}