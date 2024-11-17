namespace db_programming
{
    internal class Program
    {
        // Exercise 1: Function to calculate the sum of two integers
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        // Exercise 2: Procedure to display the multiplication table for numbers from 1 to 10
        static void DisplayMultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }

                Console.WriteLine();
            }
        }

        // Exercise 3: Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // Exercise 1: Overloaded function to calculate area
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateArea(double radiusOrSide, bool isCircle)
        {
            return isCircle ? Math.PI * radiusOrSide * radiusOrSide : radiusOrSide * radiusOrSide;
        }

        // Exercise 2: Overloaded function to print values of different types
        static void Print(int value)
        {
            Console.WriteLine($"Type: {value.GetType()}, Value: {value}");
        }

        static void Print(double value)
        {
            Console.WriteLine($"Type: {value.GetType()}, Value: {value}");
        }

        static void Print(string value)
        {
            Console.WriteLine($"Type: {value.GetType()}, Value: {value}");
        }

        // Exercise 3: Overloaded function to find maximum value
        static int Maximum(int a, int b)
        {
            return a > b ? a : b;
        }

        static double Maximum(double a, double b)
        {
            return a > b ? a : b;
        }

        static int Maximum(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // Exercise 1: Function to greet the user with a default age of 18
        static void Greet(string name, int age = 18)
        {
            Console.WriteLine($"Cześć, {name}! Masz {age} lat.");
        }

        // Exercise 2: Function to calculate the gross price with a default VAT rate of 0.23
        static double CalculatePrice(double nettoPrice, double vatRate = 0.23)
        {
            return nettoPrice * (1 + vatRate);
        }

        // Exercise 3: Function to display book information with default author and year of publication
        static void DisplayBookInfo(string title, string author = "Nieznany", int year = 2020)
        {
            Console.WriteLine($"Tytuł: {title}, Autor: {author}, Rok Wydania: {year}");
        }

        static void Main()
        {
            // Exercise 1
            int sum = CalculateSum(15, 20);
            Console.WriteLine("Sum: " + sum);

            // Exercise 2
            Console.WriteLine("Multiplication Table:");
            DisplayMultiplicationTable();

            // Exercise 3
            bool isPrime = IsPrime(17);
            Console.WriteLine("Is 17 prime? " + isPrime);

            // Exercise 1: Overloaded CalculateArea
            Console.WriteLine("Area of square: " + CalculateArea(5, false));
            Console.WriteLine("Area of rectangle: " + CalculateArea(5, 10));
            Console.WriteLine("Area of circle: " + CalculateArea(7, true));

            // Exercise 2: Overloaded Print
            Print(42);
            Print(3.14);
            Print("Hello, world!");

            // Exercise 3: Overloaded Maximum
            Console.WriteLine("Max of 5 and 10 (int): " + Maximum(5, 10));
            Console.WriteLine("Max of 3.5 and 7.2 (double): " + Maximum(3.5, 7.2));
            Console.WriteLine("Max of 1, 4, and 3 (int): " + Maximum(1, 4, 3));

            // Exercise 1: Test Greet function with and without age
            Greet("Anna");
            Greet("Piotr", 25);

            // Exercise 2: Test CalculatePrice function with and without VAT rate
            double price1 = CalculatePrice(100); // with default VAT rate
            double price2 = CalculatePrice(100, 0.18); // with custom VAT rate
            Console.WriteLine($"Cena brutto (domyślny VAT): {price1}");
            Console.WriteLine($"Cena brutto (custom VAT): {price2}");

            // Exercise 3: Test DisplayBookInfo function with different combinations of arguments
            DisplayBookInfo("Programowanie C#", "Jan Kowalski", 2023);
            DisplayBookInfo("JavaScript w praktyce", "Anna Nowak");
            DisplayBookInfo("C# dla początkujących");
        }
    }
}