using System;

namespace zweiDimensionalesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] zahlentabelle = new int[3, 4];

            for(int zaehler = 0; zaehler < 3; zaehler++)
            {
                for(int zaehler2 = 0; zaehler2 < 4; zaehler2++)
                {
                    Console.Write("Geben Sie die {0}.Zeile bei der {1}.Spalte ein: ", zaehler+1, zaehler2+1);
                    zahlentabelle[zaehler, zaehler2] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Leere Zeile
            Console.WriteLine(" ");

            for (int zaehler = 0; zaehler < 3; zaehler++)
            {
                for (int zaehler2 = 0; zaehler2 < 4; zaehler2++)
                {
                    Console.WriteLine("Der Wert in der {0}.Zeile bei der {1}.Spalte lautet: {2}", zaehler + 1, zaehler2 + 1, zahlentabelle[zaehler, zaehler2]);
                }
            }
        }
    }
}
