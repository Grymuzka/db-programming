namespace db_programming.student;

public class StudentServiceWithoutDb
{
    private static List<Student> Students = new List<Student>
    {
        new Student { Id = 1, FirstName = "Jan", LastName = "Kowalski", StartYear = 2020, Major = "Computer Science", Grades = new List<int>{5,4,4,3} },
        new Student { Id = 2, FirstName = "Anna", LastName = "Nowak", StartYear = 2021, Major = "Management", Grades = new List<int>{4,4,5,5} },
        new Student { Id = 3, FirstName = "Piotr", LastName = "Wiśniewski", StartYear = 2020, Major = "Computer Science", Grades = new List<int>{3,3,4,2} },
        new Student { Id = 4, FirstName = "Maria", LastName = "Lewandowska", StartYear = 2021, Major = "Computer Science", Grades = new List<int>{5,5,5,4} },
        new Student { Id = 5, FirstName = "Krzysztof", LastName = "Kozłowski", StartYear = 2020, Major = "Economy", Grades = new List<int>{2,3,4,4} }
    };
    
    // Exercise 1: Filter students by major and start year
        public static List<Student> FilterStudentsByMajorAndStartYear(string major,
            int startYear)
        {
            return Students
                .Where(s => s.Major == major && s.StartYear == startYear)
                .ToList();
        }

        // Exercise 2: Select only First Name and Last Name
        public static List<Student> GetStudentNames()
        {
            return Students
                .Select(s => new Student { FirstName = s.FirstName, LastName = s.LastName })
                .ToList();
        }

        // Exercise 3: Sort students by LastName and FirstName
        public static List<Student> SortStudentsByLastNameAndFirstName()
        {
            return Students
                .OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .ToList();
        }

        // Exercise 4: Group students by major
        public static List<IGrouping<string, Student>> GroupStudentsByMajor()
        {
            return Students
                .GroupBy(s => s.Major)
                .ToList();
        }

        // Exercise 5: Query syntax for sorting students by LastName and FirstName
        public static List<Student> QuerySortedStudents(string major)
        {
            return (from s in Students
                where s.Major == major
                orderby s.LastName, s.FirstName
                select s).ToList();
        }

        // Print all students
        public static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        // Print names only
        public static void PrintNames(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        // Print grouped students by major
        public static void PrintGroupedByMajor(List<IGrouping<string, Student>> groupedByMajor)
        {
            foreach (var group in groupedByMajor)
            {
                Console.WriteLine($"{group.Key}: {group.Count()} students");
            }
        }

}