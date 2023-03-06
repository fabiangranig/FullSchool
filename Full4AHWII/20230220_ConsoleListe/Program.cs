using System;

namespace _20230220_ConsoleListe
{
    class Program
    {
        static void Main(string[] args)
        {
            CList Liste = new CList();
            Liste.InsertF(5);
            Liste.InsertF(3);
            Liste.InsertF(111);
            Liste.InsertF(3);
            Liste.InsertF(8);
            Liste.InsertF(99);
            Liste.InsertF(6);
            Liste.InsertF(188);
            Liste.InsertF(8);

            Liste.Anzeigen();

            Console.WriteLine();

            Liste.QuickSort();

            Liste.Anzeigen();
        }
    }
}
