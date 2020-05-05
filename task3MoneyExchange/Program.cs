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

            string[] arrayED = new string[7];
            int i = 0;
            double gryvna, buf, dinar;
            string result, search;
            Console.WriteLine("Enter UAH sum");
            gryvna = Convert.ToDouble(Console.ReadLine());
            using (var page = new WebClient())
            {
                result = page.DownloadString("https://freecurrencyrates.com/ru/convert-UAH-RSD");
            }
            Regex regex = new Regex("курс обмена UAH/RSD - [0-9]{1}.[0-9]{2}", RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(result);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                   
                    arrayED[i] = match.Value;
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            search = arrayED[0];
            search = search.Substring(22, 4);
            search = search.Replace(".", ",");
            buf = Convert.ToDouble(search);
            dinar = gryvna * buf;
            
            Console.WriteLine($"{gryvna} UAH = {dinar} dinar");
            Console.ReadLine();

        }
    }
}
