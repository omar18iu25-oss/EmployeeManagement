using Microsoft.AspNetCore.Mvc;

namespace HumaVolveAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDepartments()
        {
            return Ok(new List<string>
            {
                "HR",
                "IT",
                "Finance"
            });
        }
    }
}