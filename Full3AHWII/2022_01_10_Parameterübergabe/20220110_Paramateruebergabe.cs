using System;

namespace _20220110_Paramateruebergabe
{
    class Program
    {
        static void TestRef(ref char i)
        {
            i = 'x';
        }

        static void TestNoRef(char i)
        {
            i = 'c';
        }

        static void TestOut(out char i)
        {
            i = 'c';
        }

        static void Main(string[] args)
        {
            char i = 'a';
            char j;

            TestRef(ref i);
            Console.WriteLine("{0}", i);

            TestNoRef(i);
            Console.WriteLine("{0}", i);

            TestOut(out j);
            Console.WriteLine("{0}", j);

            Console.ReadLine();
        }
    }
}
