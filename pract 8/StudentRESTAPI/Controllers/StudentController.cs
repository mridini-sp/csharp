using Microsoft.AspNetCore.Mvc;
using StudentRESTAPI.Models;

namespace StudentRESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        static List<Student> s = new()
        {
            new(){Id=1,Name="Rahul",Course="MCA",Age=22},
            new(){Id=2,Name="Priya",Course="MCA",Age=21}
        };

        [HttpGet]
        public IActionResult Get() => Ok(s);

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var x = s.FirstOrDefault(a => a.Id == id);
            return x == null ? NotFound() : Ok(x);
        }

        [HttpPost]
        public IActionResult Post(Student x)
        {
            x.Id = s.Count + 1; s.Add(x); return Ok(x);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student x)
        {
            var y = s.FirstOrDefault(a => a.Id == id);
            if (y == null) return NotFound();
            y.Name = x.Name; y.Course = x.Course; y.Age = x.Age;
            return Ok(y);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var x = s.FirstOrDefault(a => a.Id == id);
            if (x == null) return NotFound();
            s.Remove(x); return NoContent();
        }
    }
}