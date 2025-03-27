using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForEmployee
{
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            _name = name;
            _salary = salary;
        }

        public string _name { get; set; }
        public decimal _salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Employee : {_name}. Salary : {_salary}");
        }
    }
}
