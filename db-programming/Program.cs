using db_programming.student;

namespace db_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using (var context = new StudentContext())
            // {
            //     context.Database.EnsureCreated();
            //
            //     List<Student> filteredStudents = StudentService.FilterStudentsByMajorAndStartYear(context, "Computer Science", 2020);
            //     StudentService.PrintStudents(filteredStudents);
            //
            //     List<Student> selectedNames = StudentService.GetStudentNames(context);
            //     StudentService.PrintNames(selectedNames);
            //
            //     List<Student> sortedStudents = StudentService.SortStudentsByLastNameAndFirstName(context);
            //     StudentService.PrintStudents(sortedStudents);
            //
            //     var groupedByMajor = StudentService.GroupStudentsByMajor(context);
            //     StudentService.PrintGroupedByMajor(groupedByMajor);
            //
            //     List<Student> querySortedStudents = StudentService.QuerySortedStudents(context, "Computer Science");
            //     StudentService.PrintStudents(querySortedStudents);
            // }
            
            List<Student> filteredStudents = StudentServiceWithoutDb.FilterStudentsByMajorAndStartYear("Computer Science", 2020);
            StudentService.PrintStudents(filteredStudents);

            // List<Student> selectedNames = StudentServiceWithoutDb.GetStudentNames();
            // StudentService.PrintNames(selectedNames);
            //
            // List<Student> sortedStudents = StudentServiceWithoutDb.SortStudentsByLastNameAndFirstName();
            // StudentService.PrintStudents(sortedStudents);
            //
            // var groupedByMajor = StudentServiceWithoutDb.GroupStudentsByMajor();
            // StudentService.PrintGroupedByMajor(groupedByMajor);
            //
            // List<Student> querySortedStudents = StudentServiceWithoutDb.QuerySortedStudents("Computer Science");
            // StudentService.PrintStudents(querySortedStudents);
        }
    }
}