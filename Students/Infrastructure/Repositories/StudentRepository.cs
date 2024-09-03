using Microsoft.AspNetCore.Connections;
using Students.Domain.Model;
using Students.Infrastructure.Interface;

namespace Students.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var student = _context.Student.Find(id);
            _context.Student.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Student.ToList();   
        }

        public Student GetById(Guid id)
        {
            return _context.Student.Find(id);
        }

        public void Update(Student student)
        {
            var StudentId = _context.Student.Find(student.id);

            StudentId.Up(student.name, student.age, student.active);
            _context.SaveChanges();
        }
    }
}
