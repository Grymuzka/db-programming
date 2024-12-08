namespace db_programming;

public class Lista
{
    public static void RunMethods()
    {
        List<string> names = new List<string>();

        AddFiveNames(names);

        Console.WriteLine("\nLista wprowadzonych imion:");
        PrintAllNames(names);

        DeleteName(names);

        Console.WriteLine("\nZaktualizowana lista imion:");
        PrintAllNames(names);

        PrintNumberOfNames(names);
    }

    private static void PrintNumberOfNames(List<string> names)
    {
        Console.WriteLine($"\nLiczba imion na liście: {names.Count}");
    }

    private static void PrintAllNames(List<string> names)
    {
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static void AddFiveNames(List<string> names)
    {
        Console.WriteLine("Wprowadź 5 imion:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Imię {i + 1}: ");
            string name = Console.ReadLine();
            names.Add(name);
        }
    }

    private static void DeleteName(List<string> names)
    {
        Console.Write("\nPodaj imię do usunięcia: ");
        string nameToDelete = Console.ReadLine();

        if (names.Remove(nameToDelete))
        {
            Console.WriteLine($"Imię '{nameToDelete}' zostało usunięte.");
        }
        else
        {
            Console.WriteLine($"Imię '{nameToDelete}' nie istnieje na liście.");
        }
    }
}