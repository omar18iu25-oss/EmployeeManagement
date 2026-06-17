using Microsoft.AspNetCore.Mvc;

namespace HumaVolveAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static List<string> employees = new List<string>
        {
            "Ahmed", "Sara", "Ali"
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee(string name)
        {
            employees.Add(name);
            return Ok(employees);
        }
    }
}