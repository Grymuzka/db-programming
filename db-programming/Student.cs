using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_programming;

// [Table("Student")]
public class Student
{
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string IndexNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public static void AddStudent(UniversityContext context, string indexNumber, string firstName, string lastName)
    {
        var student = new Student
        {
            IndexNumber = indexNumber,
            FirstName = firstName,
            LastName = lastName,
        };
    
        context.Students.Add(student);
        context.SaveChanges();
        Console.WriteLine($"Dodano studenta: {firstName} {lastName}");
    }
    
    public static void GetAllStudents(UniversityContext context)
    {
        var students = context.Students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Imię: {student.FirstName}, Nazwisko: {student.LastName}, Indeks: {student.IndexNumber}");
        }
    }
    
    public static void GetStudent(UniversityContext context, int id)
    {
        var student = context.Students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            Console.WriteLine($"Id: {student.Id}, Imię: {student.FirstName}, Nazwisko: {student.LastName}, Indeks: {student.IndexNumber}");
        }
        else
        {
            Console.WriteLine("Student nie został znaleziony.");
        }
    }
    
    public static void UpdateStudent(UniversityContext context, int id, string newIndexNumber, string newFirstName, string newLastName)
    {
        var student = context.Students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            student.IndexNumber = newIndexNumber;
            student.FirstName = newFirstName;
            student.LastName = newLastName;

            context.SaveChanges();
            Console.WriteLine("Dane studenta zostały zaktualizowane.");
        }
        else
        {
            Console.WriteLine("Student nie został znaleziony.");
        }
    }
    
    public static void DeleteStudent(UniversityContext context, int id)
    {
        var student = context.Students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            context.Students.Remove(student);
            context.SaveChanges();
            Console.WriteLine("Student został usunięty.");
        }
        else
        {
            Console.WriteLine("Student nie został znaleziony.");
        }
    }
}