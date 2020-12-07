using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeAPI.Services;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private ILogger _logger;
        private IEmployeeAPI _API;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeAPI api)
        {
            _logger = logger;
            _API = api;
        }

        [HttpGet("/api/employees")]
        public ActionResult<List<Employee>> GetEmployee()
        {
            
            return _API.GetEmployees();
        }

        [HttpPost("/api/employees")]
        public ActionResult<Employee> AddEmployee(Employee employee)
        {
            _API.AddEmployee(employee);
            return employee;
        }

        [HttpPut("/api/employees/{name}")]
        public ActionResult<Employee> UpdateEmployee(string name, Employee employee)
        {
            _API.UpdateEmployee(name, employee);
            return employee;
        }

        [HttpDelete("/api/employees/{name}")]
        public ActionResult<string> DeleteEmployee(string name)
        {
            _API.DeleteEmployee(name);
            return name;
        }
    }
}
