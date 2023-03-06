using System;

namespace _20230227_DoppeltVerkettet
{
    class Program
    {
        static void Main(string[] args)
        {
            CList Liste = new CList();
            Liste.InsertB(20);
            Liste.InsertB(10);
            Liste.InsertB(30);
            Liste.InsertB(50);

            Console.WriteLine("Vorfährst: ");
            Liste.Anzeigen();

            Console.WriteLine("Rückwärts:");
            Liste.AnzeigenPrev();

            Liste.BubbleSort();
            Console.WriteLine();

            Console.WriteLine("Vorfährst: ");
            Liste.Anzeigen();

            Console.WriteLine("Rückwärts:");
            Liste.AnzeigenPrev();
        }
    }
}
