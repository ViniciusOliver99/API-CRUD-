using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Students.Domain.Model
{
    [Table("student")]
    public class Student
    {
        [Key]
        public Guid   id       { get; private set; }
        public string name     { get; set; }
        public int    age      { get; set; }    
        public bool   active   { get; set; }

        public Student(string name, int age)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.age = age;
            this.active = true;
        }

        public void Up(string name, int age, bool active)
        {
            this.name = name;
            this.age = age;
            this.active = active;
        }
    }
}
