using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_programming;


// [Table("Course")]
public class Course
{
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Period { get; set; }
    public int MinStudentCount { get; set; }
    public int MaxStudentCount { get; set; }
}