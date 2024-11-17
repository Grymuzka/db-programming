namespace db_programming.employee;

public class Employee
{
    private string firstName;
    private string lastName;
    private string position;
    private decimal salary;

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Position { get => position; set => position = value; }

    public decimal Salary
    {
        get => salary;
        set
        {
            decimal minimumSalary = 3490m;

            if (value >= minimumSalary)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine($"Error: Salary cannot be less than {minimumSalary} PLN.");
            }
        }
    }

    public string GetFullData()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}, Position: {Position}, Salary: {Salary} PLN";
    }
}