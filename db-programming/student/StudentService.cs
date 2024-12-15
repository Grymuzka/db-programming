namespace db_programming.student;

public static class StudentService
{
     // Exercise 1: Filter students by major and start year
        public static List<Student> FilterStudentsByMajorAndStartYear(StudentContext context, string major,
            int startYear)
        {
            return context.Students
                .Where(s => s.Major == major && s.StartYear == startYear)
                .ToList();
        }

        // Exercise 2: Select only First Name and Last Name
        public static List<Student> GetStudentNames(StudentContext context)
        {
            return context.Students
                .Select(s => new Student { FirstName = s.FirstName, LastName = s.LastName })
                .ToList();
        }

        // Exercise 3: Sort students by LastName and FirstName
        public static List<Student> SortStudentsByLastNameAndFirstName(StudentContext context)
        {
            return context.Students
                .OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .ToList();
        }

        // Exercise 4: Group students by major
        public static List<IGrouping<string, Student>> GroupStudentsByMajor(StudentContext context)
        {
            return context.Students
                .GroupBy(s => s.Major)
                .ToList();
        }

        // Exercise 5: Query syntax for sorting students by LastName and FirstName
        public static List<Student> QuerySortedStudents(StudentContext context, string major)
        {
            return (from s in context.Students
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