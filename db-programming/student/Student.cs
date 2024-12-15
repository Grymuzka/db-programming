using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_programming.student;

public class Student
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int StartYear { get; set; }
    public string Major { get; set; }
    
    public List<int> Grades { get; set; }
}

// CREATE TABLE Students (
    // Id INT PRIMARY KEY IDENTITY(1,1),
    // FirstName NVARCHAR(100) NOT NULL,
    // LastName NVARCHAR(100) NOT NULL,
    // StartYear INT NOT NULL,
    // Major NVARCHAR(100) NOT NULL
// );
