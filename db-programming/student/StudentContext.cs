using Microsoft.EntityFrameworkCore;

namespace db_programming.student;

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=University;Trusted_Connection=True;");
        // optionsBuilder.UseSqlServer("Server=DES-24-0264;Database=Notowania;User Id=sa;Password=Program0wanieB@zDanych!");
    }
}