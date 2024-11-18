using System.Globalization;
using CsvHelper;

namespace db_programming.quotation;

using CsvHelper.Configuration;
using System;

public class Quotation
{
    public string Ticker { get; set; }
    public string Per { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }  
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
    public decimal Vol { get; set; }
    public int OpenInt { get; set; }
}

