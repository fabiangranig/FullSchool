using System;

namespace _20221212_Demo_Rekursion
{
    class Program
    {
        static double Fakultaet(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n * Fakultaet(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ergebnis: "+ Fakultaet(5));
        }
    }
}
