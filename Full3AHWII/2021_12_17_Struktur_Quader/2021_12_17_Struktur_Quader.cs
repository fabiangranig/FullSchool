//Fabian Granig 3AWHII
//17.12.2021
//Struktur: Quader
using System;

namespace _20211217_Struktur_Quader
{
    //Create the struct "Quader"
    struct Quader
    {
        public double Laenge;
        public double Breite;
        public double Hoehe;
    }

    class Program
    {
        //Create function "Eingabe"
        static Quader Eingabe(double Laenge, double Breite, double Hoehe)
        {
            //Create a quader
            Quader quader;

            //Put the information in the quader
            quader.Laenge = Laenge;
            quader.Breite = Breite;
            quader.Hoehe = Hoehe;

            //Return a Quader
            return quader;
        }

        //Create function "Anzeigen"
        static void Anzeigen(Quader quader)
        {
            //Output the information
            Console.WriteLine("Die Länge beträgt: {0}", quader.Laenge);
            Console.WriteLine("Die Breite beträgt: {0}", quader.Breite);
            Console.WriteLine("Die Höhe beträgt: {0}", quader.Hoehe);
        }

        //Create function "Volumen"
        static double Volumen(Quader quader)
        {
            //Calculate the "Volumen"
            double volumen = quader.Laenge * quader.Breite * quader.Hoehe;

            //Return the solution
            return volumen;
        }

        //Create function "Oberflaeche"
        static double Oberflaeche(Quader quader)
        {
            //Calculate the "Oberfläche"
            double oberflaeche = 2 * quader.Laenge * quader.Breite + 2 * quader.Laenge * quader.Hoehe + 2 * quader.Breite * quader.Hoehe;

            //Return the solution
            return oberflaeche;
        }

        //Create function "Vergleichen"
        static int Vergleichen(Quader quader1, Quader quader2)
        {
            //Calculate both "Volumen" of the "Quaders"
            double volumen1 = Volumen(quader1);
            double volumen2 = Volumen(quader2);

            //Compare them with each other
            if(volumen1 > volumen2)
            {
                return 1;
            }
            else
            {
                if(volumen2 > volumen1)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            //Request the user to write information into the console
            Console.WriteLine("Geben Sie die Werte für ihr Quader ein: ");
            
            //Input the data
            Console.Write("Geben Sie bitte die Länge ein: ");
            double Laenge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie bitte die Breite ein: ");
            double Breite = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie bitte die Höhe ein: ");
            double Hoehe = Convert.ToDouble(Console.ReadLine());

            //Call function "Eingabe" to put it in the "Quader"
            Quader quader1 = Eingabe(Laenge, Breite, Hoehe);

            //empty Line
            Console.WriteLine(" ");

            //Output the inputed data
            Console.WriteLine("Hier werden die Werte angezeigt welche eingegeben wurden: ");
            Anzeigen(quader1);

            //empty Line
            Console.WriteLine(" ");

            //Calculate and Output the "Volumen"
            double quader1_volumen = Volumen(quader1);
            Console.WriteLine("Das Volumen beträgt: {0}", quader1_volumen);

            //Calculate the oberflaeche
            double quader1_oberflaeche = Oberflaeche(quader1);
            Console.WriteLine("Die Oberfläche beträgt: {0}", quader1_oberflaeche);

            //empty Line
            Console.WriteLine(" ");

            //Declare new quader to compare
            Quader quader2;
            quader2.Laenge = 6;
            quader2.Breite = 5;
            quader2.Hoehe = 4;

            //Calculate the bigger "Quader"
            int quader_vergleich = Vergleichen(quader1, quader2);
            Console.WriteLine("Das {0}.Quadrat ist größer.", quader_vergleich);
        }
    }
}
