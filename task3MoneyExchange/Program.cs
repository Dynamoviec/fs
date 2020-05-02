using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace task3MoneyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double gryvna, buf, dinar;
            string result, search;
            Console.WriteLine("Enter UAH sum");
            gryvna = Convert.ToDouble(Console.ReadLine());
            using (var page = new WebClient())
            {
                result = page.DownloadString("https://freecurrencyrates.com/ru/convert-UAH-RSD");
            }
            search = result.Substring(20877, 4);
            search = search.Replace(".", ",");
            buf = Convert.ToDouble(search);
            dinar = gryvna * buf;
            
            Console.WriteLine($"{gryvna} UAH = {dinar} dinar");
            Console.ReadLine();

        }
    }
}
