using System;

namespace _20230227_DoppeltVerkettet
{
    class Program
    {
        static void Main(string[] args)
        {
            CList Liste = new CList();
            Liste.InsertF(20);
            Liste.InsertF(10);
            Liste.InsertB(30);
            Liste.InsertB(50);
            Liste.InsertIndex(40,3);
            Liste.InsertIndex(16, 2);
            Liste.InsertIndex(24, 4);

            Console.WriteLine("Vorfährst: ");
            Liste.Anzeigen();

            Console.WriteLine("Rückwärts:");
            Liste.AnzeigenPrev();

            Liste.QuickSort();

            Console.WriteLine();

            Console.WriteLine("Vorfährst: ");
            Liste.Anzeigen();

            Console.WriteLine("Rückwärts:");
            Liste.AnzeigenPrev();
        }
    }
}
