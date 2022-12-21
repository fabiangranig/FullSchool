using System;

namespace _20221129_Sortieren
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2,100,15,17,4,47,43,8 };
            Sort s1 = new Sort(numbers);
            s1.SortierenDurchEinfuegen();
            s1.Anzeigen();
        }
    }
}
