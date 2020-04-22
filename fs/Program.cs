using System;

namespace fs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] celsius = new int[201];
            int[] kelvins = new int[201];
            double[] fahrenheits = new double[201];
            celsius[0] = -100;
            kelvins[0] = 173;
            fahrenheits[0] = -148;
            const int FieldWidthRightAligned = 20;
            for (int i = 1; i < celsius.Length; i++)
            {
                celsius[i]= celsius[i-1]+1;
            }
            for (int i = 1; i < kelvins.Length; i++)
            {
                kelvins[i] = kelvins[i-1]+1; 
            }
            for (int i = 1; i < fahrenheits.Length; i++)
            {
                fahrenheits[i] = fahrenheits[i-1] + 1.8;
            }
            Console.WriteLine("Celsius \t kelvins \t fahrenheits");
            for (int i = 0 ; i < celsius.Length; i++)
            {
                Console.WriteLine($"{celsius[i]} \t\t {kelvins[i]} \t {fahrenheits[i],FieldWidthRightAligned:F1}");
            }
            Console.ReadLine();
        }
    }
}
