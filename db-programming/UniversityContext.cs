using Microsoft.EntityFrameworkCore;

namespace db_programming;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=University;Trusted_Connection=True;");
        // optionsBuilder.UseSqlServer("Server=DES-24-0264;Database=Notowania;User Id=sa;Password=Program0wanieB@zDanych!");
    }
}