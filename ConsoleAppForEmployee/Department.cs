using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForEmployee
{
    class Department
    {
        public string _name { get; set; }
        public int _employeeLimit { get; set; }

        public Employee[] _employees;
        public Department(string name, int employeeLimit)
        {
            _name = name;
            _employeeLimit = employeeLimit;
            _employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[^1] = employee;
        }

        public Employee[] GetAllEmployees()
        {
            if (_employees is not null)
                return _employees;
            else
                return null;
        }

        public void GetAndPrintAllEmployees()
        {
            Employee[] employees = GetAllEmployees();
            foreach (Employee employee in employees)
                employee.ShowInfo();
        }
    }
}
