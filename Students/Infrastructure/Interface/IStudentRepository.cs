using Students.Domain.Model;

namespace Students.Infrastructure.Interface
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById (Guid id);
        void Add(Student student);
        void Update(Student student);
        void Delete(Guid id);
    }
}
