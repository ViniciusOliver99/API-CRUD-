using Microsoft.AspNetCore.Mvc;
using Students.Application.ViewModel;
using Students.Domain.Model;
using Students.Infrastructure.Interface;

namespace Students.Controllers.v1
{
    [ApiController]
    [Route("api/vi/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;              
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var stutent = _studentRepository.GetAll();
            return Ok(stutent);
        }
        [HttpPost]
        public IActionResult Add([FromForm] StudentViewModel studentView )
        {
            var student = new Student(studentView.name, studentView.age);
            _studentRepository.Add(student);
            return Ok(student);
        }
        [HttpPut]
        [Route("id")]
        public IActionResult Update(Guid id, [FromForm] StudentUpView studentView) 
        {
            var studentId = _studentRepository.GetById(id);
            studentId.Up(studentView.name, studentView.age, studentView.active);
            _studentRepository.Update(studentId);
            return Ok(studentId);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id) 
        {
            _studentRepository.Delete(id);
            return Ok();
        }
    }
}
