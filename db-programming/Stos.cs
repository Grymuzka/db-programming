namespace db_programming;

public class Stos
{
    public static void RunMethods()
    {
        Stack<string> pages = new Stack<string>();
        string actualPage = "Brak strony"; 

        while (true)
        {
            ShowMenu();

            HandleChoice(pages, ref actualPage);
        }
    }

    private static bool HandleChoice(Stack<string> pages, ref string actualPage)
    {
        String choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                MoveToNewPage(pages, out actualPage);
                break;

            case "2":
                MoveToPreviousPage(pages, out actualPage);
                break;

            case "3":
                Console.WriteLine($"Aktualna strona: {actualPage}");
                break;

            case "4":
                Console.WriteLine($"Liczba stron na stosie: {pages.Count}");
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

    private static void MoveToPreviousPage(Stack<string> pages, out string actualPage)
    {
        if (pages.Count > 0)
        {
            pages.Pop();
            actualPage = pages.Count > 0 ? pages.Peek() : "Brak strony";
            Console.WriteLine($"Cofnięto się. Aktualna strona: {actualPage}");
        }
        else
        {
            actualPage = "Brak strony";
            Console.WriteLine("Nie można cofnąć, stos jest pusty.");
        }
    }

    private static void MoveToNewPage(Stack<string> pages, out string actualPage)
    {
        Console.Write("Podaj adres nowej strony: ");
        string newPage = Console.ReadLine();
        pages.Push(newPage);
        actualPage = newPage;
        Console.WriteLine($"Przeszedłeś do nowej strony: {newPage}");
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n=== Symulacja Stosu Stron Internetowych ===");
        Console.WriteLine("1. Przejdź do nowej strony");
        Console.WriteLine("2. Cofnij się do poprzedniej strony");
        Console.WriteLine("3. Wyświetl aktualną stronę");
        Console.WriteLine("4. Wyświetl liczbę stron na stosie");
        Console.WriteLine("5. Wyjdź z programu");
        Console.Write("Wybierz opcję (1-5): ");
    }
}