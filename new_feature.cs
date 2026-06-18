using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HumaVolveAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "mohamed", Position = "head", Salary = 30000 },
            new Employee { Id = 2, Name = "sara", Position = "analyst", Salary = 15000 }
        };

        [HttpGet("get-all")]
        public IActionResult GetAllEmployees()
        {
            return Ok(_employees);
        }

        [HttpPost("add")]
        public IActionResult AddEmployee([FromBody] Employee newEmployee)
        {
            if (newEmployee == null)
                return BadRequest("Wrong input");

            newEmployee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(newEmployee);

            return Ok(newEmployee);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
}
