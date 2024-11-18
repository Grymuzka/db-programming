using db_programming.employee;

namespace db_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "John";
            employee.LastName = "Doe";
            employee.Position = "Developer";

            employee.Salary = 4000; 

            Console.WriteLine(employee.GetFullData());
        }
    }
}