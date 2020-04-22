using System;

namespace task2string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                text = text.Replace("  ", " ");
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
