namespace db_programming;

public class Kolejka
{
    public static void RunMethods()
    {
        Queue<string> customerQueue = new Queue<string>();

        while (true)
        {
            ShowMenu();

            if (HandleChoice(customerQueue)) return;
        }
    }

    private static bool HandleChoice(Queue<string> customerQueue)
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                AddCustomer(customerQueue);
                break;

            case "2":
                ServeCustomer(customerQueue);
                break;

            case "3":
                PrintWaitingCustomers(customerQueue);
                break;

            case "4":
                Console.WriteLine($"Liczba klientów w kolejce: {customerQueue.Count}");
                break;

            case "5":
                Console.WriteLine("Zakończono program.");
                return true;

            default:
                Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                break;
        }

        return false;
    }

    private static void PrintWaitingCustomers(Queue<string> customerQueue)
    {
        if (customerQueue.Count > 0)
        {
            Console.WriteLine("Lista oczekujących klientów:");
            foreach (string customer in customerQueue)
            {
                Console.WriteLine(customer);
            }
        }
        else
        {
            Console.WriteLine("Kolejka jest pusta.");
        }
    }

    private static void ServeCustomer(Queue<string> customerQueue)
    {
        if (customerQueue.Count > 0)
        {
            string servedCustomer = customerQueue.Dequeue();
            Console.WriteLine($"Obsłużono klienta: {servedCustomer}");
        }
        else
        {
            Console.WriteLine("Kolejka jest pusta. Brak klientów do obsłużenia.");
        }
    }

    private static void AddCustomer(Queue<string> customerQueue)
    {
        Console.Write("Podaj imię klienta, którego chcesz dodać: ");
        string customer = Console.ReadLine();
        customerQueue.Enqueue(customer);
        Console.WriteLine($"Dodano klienta: {customer}");
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n=== Symulacja Kolejki Klientów ===");
        Console.WriteLine("1. Dodaj nowego klienta do kolejki");
        Console.WriteLine("2. Obsłuż klienta (usuń z kolejki)");
        Console.WriteLine("3. Wyświetl listę oczekujących klientów");
        Console.WriteLine("4. Wyświetl liczbę klientów w kolejce");
        Console.WriteLine("5. Zakończ program");
        Console.Write("Wybierz opcję (1-5): ");
    }
}