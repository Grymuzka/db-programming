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


// CREATE TABLE Students (
//     Id INT PRIMARY KEY IDENTITY(1,1),
//     IndexNumber NVARCHAR(20) NOT NULL,
//     FirstName NVARCHAR(100) NOT NULL,
//     LastName NVARCHAR(100) NOT NULL
// );

// CREATE TABLE Courses (
//     Id INT PRIMARY KEY IDENTITY(1,1),
//     Name NVARCHAR(255) NOT NULL,
//     Period DATETIME NOT NULL,
//     MinStudentCount INT NOT NULL,
//     MaxStudentCount INT NOT NULL
// );

// CREATE TABLE Enrollments (
//     Id INT PRIMARY KEY IDENTITY(1,1),
//     StudentId INT NOT NULL,
//     CourseId INT NOT NULL,
//     EnrollmentDate DATETIME NOT NULL,
//     FOREIGN KEY (StudentId) REFERENCES Students(Id),
//     FOREIGN KEY (CourseId) REFERENCES Courses(Id)
// );