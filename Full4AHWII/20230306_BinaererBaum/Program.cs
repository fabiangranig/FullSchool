using System;

namespace _20230306_BinaererBaum
{
    class Program
    {
        static void Main(string[] args)
        {
            CBaum mybaum = new CBaum();

            mybaum.Insert(7);
            mybaum.Insert(5);
            mybaum.Insert(4);
            mybaum.Insert(1);
            mybaum.Insert(3);
            mybaum.Insert(6);
            mybaum.Insert(10);
            mybaum.Insert(9);
            mybaum.Insert(11);
            mybaum.Insert(8);

            mybaum.AnzeigenInorder();

            Console.WriteLine();

            mybaum.Delete(7);
            mybaum.Delete(8);
            mybaum.Delete(11);
            mybaum.Delete(4);
            mybaum.Delete(3);

            Console.WriteLine();

            mybaum.AnzeigenInorder();
        }
    }
}
