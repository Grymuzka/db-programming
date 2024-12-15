using db_programming.student;

namespace db_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Upewniamy się, że baza danych jest tworzona
                context.Database.EnsureCreated();

                // Exercise 1: Filter students
                var filteredStudents = FilterStudentsByMajorAndStartYear(context, "Computer Science", 2020);
                PrintStudents(filteredStudents);

                // Exercise 2: Projection (Select)
                var selectedNames = GetStudentNames(context);
                PrintNames(selectedNames);

                // Exercise 3: Sorting results
                var sortedStudents = SortStudentsByLastNameAndFirstName(context);
                PrintStudents(sortedStudents);

                // Exercise 4: Grouping data (GroupBy)
                var groupedByMajor = GroupStudentsByMajor(context);
                PrintGroupedByMajor(groupedByMajor);

                // Exercise 5: Query syntax
                var querySortedStudents = QuerySortedStudents(context, "Computer Science");
                PrintStudents(querySortedStudents);
            }
        }

        // Exercise 1: Filter students by major and start year
        static List<Student> FilterStudentsByMajorAndStartYear(StudentContext context, string major,
            int startYear)
        {
            return context.Students
                .Where(s => s.Major == major && s.StartYear == startYear)
                .ToList();
        }

        // Exercise 2: Select only First Name and Last Name
        static List<Student> GetStudentNames(StudentContext context)
        {
            return context.Students
                .Select(s => new Student { FirstName = s.FirstName, LastName = s.LastName })
                .ToList();
        }

        // Exercise 3: Sort students by LastName and FirstName
        static List<Student> SortStudentsByLastNameAndFirstName(StudentContext context)
        {
            return context.Students
                .OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .ToList();
        }

        // Exercise 4: Group students by major
        static List<IGrouping<string, Student>> GroupStudentsByMajor(StudentContext context)
        {
            return context.Students
                .GroupBy(s => s.Major)
                .ToList();
        }

        // Exercise 5: Query syntax for sorting students by LastName and FirstName
        static List<Student> QuerySortedStudents(StudentContext context, string major)
        {
            return (from s in context.Students
                where s.Major == major
                orderby s.LastName, s.FirstName
                select s).ToList();
        }

        // Print all students
        static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        // Print names only
        static void PrintNames(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        // Print grouped students by major
        static void PrintGroupedByMajor(List<IGrouping<string, Student>> groupedByMajor)
        {
            foreach (var group in groupedByMajor)
            {
                Console.WriteLine($"{group.Key}: {group.Count()} students");
            }
        }
    }
}