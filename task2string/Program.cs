using System;

namespace task2string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            int LENGTH = text.Length;

            for (int i = 0; i < LENGTH; i++)
            {
                text = text.Replace("  ", " ");
            
            }
            Console.WriteLine(text);
            Console.WriteLine($"'{text}', text len = {text.Length}");
            Console.ReadLine();
        }
    }
}
