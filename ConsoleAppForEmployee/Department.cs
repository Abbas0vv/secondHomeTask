using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForEmployee
{
    class Department
    {
        public Department(string name, int employeeLimit, Employee[] employees)
        {
            _name = name;
            _employeeLimit = employeeLimit;
            _employees = employees;
        }

        public string _name { get; set; }
        public int _employeeLimit { get; set; }
        public Employee[] _employees { get; set; }

        public void AddEmployee(string name, decimal salary)
        {
            Employee employee = new Employee(name, salary);
        }

        public void GetAllEmployees()
        {
            foreach (Employee emp in _employees)
                Console.WriteLine(emp);
        }
    }
}
