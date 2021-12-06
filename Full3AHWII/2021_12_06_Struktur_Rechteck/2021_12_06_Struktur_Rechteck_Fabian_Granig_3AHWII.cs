//Fabian Granig 3AHWII
//06.12.2021
//Struktur: Rechteck
using System;

namespace _2021_12_06_Struktur_Rechteck
{
    class Program
    {
        //Declare the struct "Rechteck"
        struct Rechteck
        {
            public double Laenge;
            public double Breite;
        }
        
        //Function "Eingabe"
        static Rechteck Eingabe()
        {
            //Declare "rechteck1"
            Rechteck rechteck;

            //Input "Länge"
            Console.Write("Bitte geben Sie die Länge ein: ");
            rechteck.Laenge = Convert.ToDouble(Console.ReadLine());

            //Intput "Breite"
            Console.Write("Bitte geben Sie die Breite ein: ");
            rechteck.Breite = Convert.ToDouble(Console.ReadLine());

            //Return the array
            return rechteck;
        }

        //Function "Anzeige"
        static void Anzeige(Rechteck rechteck)
        {
            //Output the data
            Console.WriteLine("Die Länge beträgt: " + rechteck.Laenge);
            Console.WriteLine("Die Breite beträgt: " + rechteck.Breite);
        }

        //Function "Fläche"
        static double Flaeche(Rechteck rechteck)
        {
            //Calculate with * Operator
            double flaeche = rechteck.Laenge * rechteck.Breite;

            //Return the value
            return flaeche;
        }

        //Function "Umfang"
        static double Umfang(Rechteck rechteck)
        {
            //Calculate with + and * Operator
            double umfang = (rechteck.Laenge * 2) + (rechteck.Breite * 2);

            //Return the value
            return umfang;
        }

        //Function "Vergleichen"
        static int Vergleichen(double flaeche1, double flaeche2)
        {
            //Checking which "Flaeche is bigger"
            if(flaeche1 > flaeche2)
            {
                //Return "flaeche1" is bigger
                return 1;
            }
            else
            {
                if(flaeche2 > flaeche1)
                {
                    //Return "flaeche2" is bigger
                    return 2;
                }
            }

            //Return "flaeche1" is equal to "flaeche2"
            return 0;
        }

        //Function "Diagonale"
        static double Diagonale(Rechteck rechteck)
        {
            //Calculate with Math.Functions
            double diagonale = Math.Sqrt((Math.Pow(rechteck.Laenge, 2) + Math.Pow(rechteck.Breite, 2)));

            //Return the value
            return diagonale;
        }

        static void Main(string[] args)
        {
            //Call "Eingabe"
            Rechteck rechteck1 = Eingabe();

            //Empty Space
            Console.WriteLine(" ");

            //Call "Anzeige"
            Anzeige(rechteck1);

            //Empty Space
            Console.WriteLine(" ");

            //Call "Flaeche"
            double flaeche = Flaeche(rechteck1);
            Console.WriteLine("Die Fläche beträgt: " + flaeche);

            //Call "Umfang"
            double umfang = Umfang(rechteck1);
            Console.WriteLine("Der Umfang beträgt: " + umfang);

            //Call "Vergleichen"
            double flaeche2 = 5.0;
            Console.WriteLine("Die Fläche des {0}.Rechteck ist größer.", Vergleichen(flaeche, flaeche2));

            //Call "Diagonale"
            double diagonale = Diagonale(rechteck1);
            Console.WriteLine("Die Diagonale beträgt: " + diagonale);
        }
    }
}
