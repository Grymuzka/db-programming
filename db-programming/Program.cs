namespace db_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                Student.AddStudent(context, "Jan", "Kowalski", "Grupa A");

                Student.GetAllStudents(context);

                Student.GetStudent(context, 1);

                Student.UpdateStudent(context, 1, "Janusz", "Nowak", "Grupa B");

                Student.DeleteStudent(context, 1);
            }
        }
    }
}