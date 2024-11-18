using System.Numerics;
using System.Text.Json;

namespace db_programming.quotation;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class QuotationService
{
    public static List<Quotation> GetQuotations()
    {
        List<Quotation> quotations = new List<Quotation>();
        string directoryPath = "/home/wika/RiderProjects/db-programming/db-programming/data";
        
        foreach (var file in Directory.GetFiles(directoryPath, "*.txt"))
        {
            quotations.AddRange(GetQuotationsFromOneFile(file));
        }

        return quotations;
    }
    
    private static List<Quotation> GetQuotationsFromOneFile(string fileName)
    {
        List<Quotation> quotations = new List<Quotation>();
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            Delimiter = ","
        };
        using (var reader = new StreamReader( fileName))
        using (var csv = new CsvReader(reader, config))
        {
            if (csv.Read())
                csv.ReadHeader();
            while (csv.Read())
            {
                var quotation = new Quotation()
                {
                    Ticker = csv.GetField("<TICKER>"),
                    Per = csv.GetField("<PER>"),
                    Date = DateTime.ParseExact(csv.GetField("<DATE>"), "yyyyMMdd", CultureInfo.InvariantCulture),
                    Time = TimeSpan.ParseExact(csv.GetField("<TIME>"), "hhmmss", CultureInfo.InvariantCulture),
                    Open = decimal.Parse(csv.GetField("<OPEN>"), CultureInfo.InvariantCulture),
                    High = decimal.Parse(csv.GetField("<HIGH>"), CultureInfo.InvariantCulture),
                    Low = decimal.Parse(csv.GetField("<LOW>"), CultureInfo.InvariantCulture),
                    Close = decimal.Parse(csv.GetField("<CLOSE>"), CultureInfo.InvariantCulture),
                    Vol = decimal.Parse(csv.GetField("<VOL>"), CultureInfo.InvariantCulture),
                    OpenInt = int.Parse(csv.GetField("<OPENINT>"), CultureInfo.InvariantCulture),
                };
                quotations.Add(quotation);
            }
        }

        return quotations;
    }
    
    public static Quotation GetQuotationByTickerAndDate(List<Quotation> quotations, string ticker, DateTime date)
    {
        var quotation = quotations.FirstOrDefault(q => 
            q.Ticker.Equals(ticker, StringComparison.OrdinalIgnoreCase) && 
            q.Date.Date == date.Date);

        if (quotation == null)
        {
            throw new InvalidOperationException($"Quotation with Ticker '{ticker}' and Date '{date:yyyy-MM-dd}' not found.");
        }

        return quotation;
    }
    
    public static void SerializeQuotation(Quotation quotation, string fileName)
    {
        if (quotation == null)
            throw new ArgumentNullException(nameof(quotation), "Quotation cannot be null.");

        if (string.IsNullOrWhiteSpace(fileName))
            throw new ArgumentException("File name cannot be null or empty.", nameof(fileName));

        string json = JsonSerializer.Serialize(quotation, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("/home/wika/RiderProjects/db-programming/db-programming/data/" + fileName, json);
        Console.WriteLine($"Quotation serialized to file: {Path.GetFullPath(fileName)}");
    }
}
