using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Services
{
    public class EmployeeAPI : IEmployeeAPI
    {
        private List<Employee> _itmEmployee;

        public EmployeeAPI()
        {
            _itmEmployee = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return _itmEmployee;
        }

        public Employee AddEmployee(Employee itmEmployee)
        {
            _itmEmployee.Add(itmEmployee);
            return itmEmployee;
        }

        public Employee UpdateEmployee(string name, Employee itmEmployee)
        {
            for (var index = _itmEmployee.Count - 1; index >=0; index--)
            {
                if (_itmEmployee[index].name==name)
                {
                    _itmEmployee[index] = itmEmployee;
                }
            }
            return itmEmployee;
        }

        public string DeleteEmployee(string id)
        {
            for (var index = _itmEmployee.Count - 1; index >= 0; index--)
            {
                if (_itmEmployee[index].name == id)
                {
                    _itmEmployee.RemoveAt(index);
                }
            }
            return id;
        }
    }
}
