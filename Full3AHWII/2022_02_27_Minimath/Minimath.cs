using System;

namespace _26022022_MiniMath
{
    class Minimath
    {
        //Erstellen der statischen Variablen
        private static double pi;
        private static double e;

        //Kapselung machen
        public static double Pi
        {
            get { return pi; }
        }
        public static double E
        {
            get { return e; }
        }

        //Berechnung der statischen Startwerte
        static Minimath()
        {
            //Berechnen von Pi
            double a = 1;
            double b = 3;
            for(int i = 1; i < 1060000000; i++)
            {
                if(i % 2 == 1)
                {
                    a -= 1 / b;
                }
                
                if(i % 2 == 0)
                {
                    a += 1 / b;
                }
                
                b += 2;
            }

            pi = a * 4;

            //Berechnen von E
            int n = 100000000;
            e = Minimath.Power(1.0/n + 1, n);
        }

        //Math.Pow
        public static double Power(double x, int n)
        {
            //for-Schleife aufmultiplizieren
            double solution = x;
            for (int i = 1; i < n; i++)
            {
                solution *= x;
            }

            //Geben das Ergebnis zurück
            return solution;
        }

        //Faktorisieren
        public static int Fak(int n)
        {
            //Durchgehen mit for-Schleifen
            int solution = 1;
            for(int i = 1; i < n + 1; i++)
            {
                solution *= i;
            }

            //Das Ergebnis zurückgeben
            return solution;
        }

        //n-Wurzel
        public static double n_Wurzel(double a, int k)
        {
            //x Wert setzen
            double x = a;

            //Durch die Iteration durchgehen
            int n = 1000000;
            for(int i = 0; i < n; i++)
            {
                double part1 = x / k;
                double part2 = 1 - (a / Minimath.Power(x, k));

                x = x - part1 * part2;
            }

            //Das Ergebnis zurückgeben
            return x;
        }

        //Wurzel
        public static double SQRT(double x)
        {
            //Den Wert mit der anderen Funktion zurückgeben
            return n_Wurzel(x, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Ausgabe der alles von allem aus der Klasse
            Console.WriteLine("Ausgabe: ");
            Console.WriteLine("-Pi beträgt: {0}", Minimath.Pi);
            Console.WriteLine("-e beträgt: {0}", Minimath.E);
            Console.WriteLine("-2 hoch 4 beträgt: {0}", Minimath.Power(2, 4));
            Console.WriteLine("-5! beträgt: {0}", Minimath.Fak(5));
            Console.WriteLine("-4 Wurzel aus 1000 beträgt: {0}", Minimath.n_Wurzel(1000, 4));
            Console.WriteLine("-Wurzel aus 2 beträgt: {0}", Minimath.SQRT(2));
        }
    }
}
