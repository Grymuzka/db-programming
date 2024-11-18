using db_programming.quotation;

namespace db_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quotations = QuotationService.GetQuotations();

            string tickerToSearch = "CDR";
            DateTime dateToSearch = new DateTime(2010, 10, 28); 
            var quotation = QuotationService.GetQuotationByTickerAndDate(quotations, tickerToSearch, dateToSearch);
            
            QuotationService.SerializeQuotation(quotation, "quotation.json");
        }
    }
}