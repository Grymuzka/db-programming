namespace db_programming;

public class Slownik
{
    public static void RunMethods()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        while (true)
        {
            ShowMenu();

            if (HandleChoice(dictionary)) return;
        }
    }

    private static bool HandleChoice(Dictionary<string, string> dictionary)
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                AddNewWord(dictionary);
                break;

            case "2":
                Translate(dictionary);
                break;

            case "3":
                DeleteWord(dictionary);
                break;

            case "4":
                ShowAllWords(dictionary);
                break;

            case "5":
                Console.WriteLine($"Liczba słów w słowniku: {dictionary.Count}");
                break;

            case "6":
                Console.WriteLine("Koniec programu. Do widzenia!");
                return true;

            default:
                Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                break;
        }

        return false;
    }

    private static void ShowAllWords(Dictionary<string, string> dictionary)
    {
        if (dictionary.Count == 0)
        {
            Console.WriteLine("Słownik jest pusty.");
        }
        else
        {
            Console.WriteLine("Słowa w słowniku:");
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }

    private static void DeleteWord(Dictionary<string, string> dictionary)
    {
        Console.Write("Podaj angielskie słowo do usunięcia: ");
        string wordToRemove = Console.ReadLine();
        if (dictionary.Remove(wordToRemove))
        {
            Console.WriteLine($"Usunięto słowo: {wordToRemove}");
        }
        else
        {
            Console.WriteLine($"Nie znaleziono słowa: {wordToRemove}");
        }
    }

    private static void Translate(Dictionary<string, string> dictionary)
    {
        Console.Write("Podaj angielskie słowo do wyszukania: ");
        string wordToFind = Console.ReadLine();
        if (dictionary.TryGetValue(wordToFind, out string translation))
        {
            Console.WriteLine($"{wordToFind} -> {translation}");
        }
        else
        {
            Console.WriteLine($"Nie znaleziono tłumaczenia dla: {wordToFind}");
        }
    }

    private static void AddNewWord(Dictionary<string, string> dictionary)
    {
        Console.Write("Podaj angielskie słowo: ");
        string englishWord = Console.ReadLine();
        Console.Write("Podaj polskie tłumaczenie: ");
        string polishTranslation = Console.ReadLine();

        if (!dictionary.ContainsKey(englishWord))
        {
            dictionary.Add(englishWord, polishTranslation);
            Console.WriteLine($"Dodano: {englishWord} -> {polishTranslation}");
        }
        else
        {
            Console.WriteLine("To słowo już istnieje w słowniku.");
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\nSłownik angielsko-polski:");
        Console.WriteLine("1. Dodaj nowe słowo");
        Console.WriteLine("2. Wyszukaj tłumaczenie");
        Console.WriteLine("3. Usuń słowo");
        Console.WriteLine("4. Wyświetl wszystkie słowa");
        Console.WriteLine("5. Wyświetl liczbę słów");
        Console.WriteLine("6. Wyjdź");
        Console.Write("Wybierz opcję: ");
    }
}