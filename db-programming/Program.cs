namespace db_programming
{
    internal class Program
    {
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

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

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateArea(double radiusOrSide, bool isCircle)
        {
            return isCircle ? Math.PI * radiusOrSide * radiusOrSide : radiusOrSide * radiusOrSide;
        }

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

        static void Greet(string name, int age = 18)
        {
            Console.WriteLine($"Cześć, {name}! Masz {age} lat.");
        }

        static double CalculatePrice(double nettoPrice, double vatRate = 0.23)
        {
            return nettoPrice * (1 + vatRate);
        }

        static void DisplayBookInfo(string title, string author = "Nieznany", int year = 2020)
        {
            Console.WriteLine($"Tytuł: {title}, Autor: {author}, Rok Wydania: {year}");
        }

        static void Main()
        {
            int sum = CalculateSum(15, 20);
            Console.WriteLine("Sum: " + sum);

            Console.WriteLine("Multiplication Table:");
            DisplayMultiplicationTable();

            bool isPrime = IsPrime(17);
            Console.WriteLine("Is 17 prime? " + isPrime);

            Console.WriteLine("Area of square: " + CalculateArea(5, false));
            Console.WriteLine("Area of rectangle: " + CalculateArea(5, 10));
            Console.WriteLine("Area of circle: " + CalculateArea(7, true));

            Print(42);
            Print(3.14);
            Print("Hello, world!");

            Console.WriteLine("Max of 5 and 10 (int): " + Maximum(5, 10));
            Console.WriteLine("Max of 3.5 and 7.2 (double): " + Maximum(3.5, 7.2));
            Console.WriteLine("Max of 1, 4, and 3 (int): " + Maximum(1, 4, 3));

            Greet("Anna");
            Greet("Piotr", 25);

            double price1 = CalculatePrice(100); 
            double price2 = CalculatePrice(100, 0.18); 
            Console.WriteLine($"Cena brutto (domyślny VAT): {price1}");
            Console.WriteLine($"Cena brutto (custom VAT): {price2}");

            DisplayBookInfo("Programowanie C#", "Jan Kowalski", 2023);
            DisplayBookInfo("JavaScript w praktyce", "Anna Nowak");
            DisplayBookInfo("C# dla początkujących");
        }
    }
}