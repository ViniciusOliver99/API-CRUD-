using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Students.Application.ViewModel
{
    public class StudentUpView
    {
        public string name { get; set; }
        public int    age  { get; set; }
        public bool active { get; set; }
    }
}
