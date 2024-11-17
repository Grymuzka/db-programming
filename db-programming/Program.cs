using db_programming.employee;

namespace db_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee class
            Employee employee = new Employee();

            // Set values
            employee.FirstName = "John";
            employee.LastName = "Doe";
            employee.Position = "Developer";

            // Assigning salary
            employee.Salary = 4000m; // Valid salary
            // employee.Salary = 3000m; // Invalid salary, below minimum salary

            // Display full employee data
            Console.WriteLine(employee.GetFullData());
        }
    }
}