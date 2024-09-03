using Microsoft.EntityFrameworkCore;
using Students.Domain.Model;

namespace Students.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public object Employee { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql
            (
                "Server=localhost;" +
                "Port=7777;Database=student;" +
                "User Id=postgres;" +
                "Password=2653"
            );
    }
}
