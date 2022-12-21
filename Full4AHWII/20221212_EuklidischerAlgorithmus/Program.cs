using System;

namespace _20221212_EuklidischerAlgorithmus
{
    class Program
    {
        static int Euklidische_Algorithmus(int a, int b)
        {
            int rest = a % b;
            if(rest == 0)
            {
                return b;
            }
            else
            {
                return Euklidische_Algorithmus(b, rest);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ergebnis: " + Euklidische_Algorithmus(70, 42));
        }
    }
}
