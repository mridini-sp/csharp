using Microsoft.AspNetCore.Mvc;
using RoutingDIExample.Services;

namespace RoutingDIExample.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Student Management System is running.");
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            return Ok("Student ID: " + id);
        }

        [HttpGet("{id}/details")]
        public IActionResult GetStudentDetails(int id)
        {
            var student = _studentService.GetStudentDetails(id);
            return Ok(student);
        }

        [HttpGet("{id}/name")]
        public IActionResult GetStudentName(int id)
        {
            string name = _studentService.GetStudentName(id);
            return Ok(name);
        }
    }
}