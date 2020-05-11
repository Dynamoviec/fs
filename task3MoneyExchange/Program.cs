using System;
using System.Net;
using System.Text.RegularExpressions;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading.Tasks;

namespace task3MoneyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double gryvna, buf, dinar;
            string result, currency;
            string text = "Текущий курс обмена UAH/RSD - ";
            Console.WriteLine("Enter UAH sum");
            gryvna = Convert.ToDouble(Console.ReadLine());
            using (var page = new WebClient())
            {
                result = page.DownloadString("https://freecurrencyrates.com/ru/convert-UAH-RSD");
            }
            bool b = result.Contains(text);
            if (b)
            {
                int index = result.IndexOf(text);
                if (index >= 0)
                {
                    currency = result.Substring(index + text.Length, 4);
                    currency = currency.Replace(".", ",");
                    buf = Convert.ToDouble(currency);
                    dinar = gryvna * buf;
                    Console.WriteLine($"{gryvna} UAH = {dinar} dinar");
                }
            }
            Console.ReadLine();

        }
    }
}
