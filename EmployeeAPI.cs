using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Services
{
        public interface IEmployeeAPI
        {
            public List<Employee> GetEmployees();
            public Employee AddEmployee(Employee itmEmployee);
            public Employee UpdateEmployee(string name, Employee itmEmployee);
            public string DeleteEmployee(string name);
        }
}
