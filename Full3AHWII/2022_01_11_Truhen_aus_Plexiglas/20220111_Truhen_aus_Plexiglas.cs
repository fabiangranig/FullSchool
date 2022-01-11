using System;

namespace _20220111_Truhen_aus_Plexiglas
{
    class Program
    {
        //Create struct "Truhe_Plexi"
        struct Truhe_Plexi
        {
            public double Breite;
            public double Hoehe;
            public double Tiefe;
        }

        //Create function "Eingabe"
        static Truhe_Plexi Eingabe(double b, double h, double t)
        {
            //Create a empty "Truhe_Plexi"
            Truhe_Plexi spaceholder;

            //Assign the values to the spaceholder
            spaceholder.Breite = b;
            spaceholder.Hoehe = h;
            spaceholder.Tiefe = t;

            //Return the "Truhe_Plexi" spaceholder
            return spaceholder;
        }

        //Create function "Ausgabe"
        static void Ausgabe(Truhe_Plexi truhe)
        {
            //Output the information
            Console.WriteLine("Die Breite beträgt: {0} cm", truhe.Breite);
            Console.WriteLine("Die Höhe beträgt: {0} cm", truhe.Hoehe);
            Console.WriteLine("Die Tiefe beträgt: {0} cm", truhe.Tiefe);
        }

        //Create function "Rohrlänge"
        static double Berechnung_Rohrlaenge(Truhe_Plexi truhe)
        {
            //Calculate every value * 4 to get the length of this site with that add everythin togheter to get the complete length
            double length = (4 * truhe.Breite) + (4 * truhe.Hoehe) + (4 * truhe.Tiefe);

            //Return the solution
            return length;
        }

        //Create function "Berechnung_Oberfläche"
        static double Berechnung_Oberflaeche(Truhe_Plexi truhe)
        {
            //Calculate the surface of each site
            double surface = (2 * (truhe.Breite * truhe.Hoehe)) + (2 * (truhe.Hoehe * truhe.Tiefe)) + (2 * (truhe.Breite * truhe.Tiefe));

            //Return the solution
            return surface;
        }

        //Create function "Berechnung_Volumen"
        static double Berechnung_Volumen(Truhe_Plexi truhe)
        {
            //Calculate the volume
            double volume = truhe.Breite * truhe.Hoehe * truhe.Tiefe;

            //Return the solution
            return volume;
        }

        static void Main(string[] args)
        {
            //Instruction
            Console.WriteLine("In diesem Programm wird eine Truhe aus Plexiglas berechnet.");

            //empty Line
            Console.WriteLine(" ");

            //Read the values in
            Console.WriteLine("Fangen wir mit der Eingabe an:");
            Console.Write("Bitte geben Sie die Breite in cm ein: ");
            double breite = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die Höhe in cm ein: ");
            double hoehe = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die Tiefe in cm ein: ");
            double tiefe = Convert.ToDouble(Console.ReadLine());

            //Put the values in an "Truhe_Plexi" with the function "Eingabe"
            Truhe_Plexi Truhe = Eingabe(breite, hoehe, tiefe);

            //empty Line
            Console.WriteLine("");

            //Output the values
            Ausgabe(Truhe);

            //empty Line
            Console.WriteLine("");

            //Get the "Rohrlänge" and output it
            double rohrlaenge = Berechnung_Rohrlaenge(Truhe);
            Console.WriteLine("Die Rohrlänge beträgt: {0} cm", rohrlaenge);

            //Get the "Plexiglasfläche" and output it
            double plexiglasflaeche = Berechnung_Oberflaeche(Truhe);
            Console.WriteLine("Die Plexiglasfläche beträgt: {0} cm²", plexiglasflaeche);

            //Get the "Volumen" and output it
            double volumen = Berechnung_Volumen(Truhe);
            Console.WriteLine("Das Volumen beträgt: {0} cm³", volumen);

            //empty Line
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //Extra Task
            //Extra Task
            //Extra Task
            //Instruction
            Console.WriteLine("Mit diesem Teil des Programmes können von mehreren Truhe die Summe der Rohrlänge berechtnet werden.");

            //empty Line
            Console.WriteLine("");

            //Input any number "Truhe" and get the "Rohrlänge"
            Console.Write("Bitte geben Sie die Anzahl der Truhen ein: ");
            int truhen_anzahl = Convert.ToInt32(Console.ReadLine());

            //Create the array
            Truhe_Plexi[] truhen_array = new Truhe_Plexi[truhen_anzahl];

            //Input the data. Also in the same for-loop calculate the sum of the "Rohrlänge"
            double summe = 0;
            for(int i = 0; i < truhen_anzahl; i++)
            {
                //empty Line
                Console.WriteLine("");

                //Enter the values in i "Truhe_Plexiglas"
                Console.WriteLine("Eingabe der {0}.Truhe:", i+1);
                Console.Write("Bitte geben Sie die Breite in cm ein: ");
                double breite2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bitte geben Sie die Höhe in cm ein: ");
                double hoehe2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bitte geben Sie die Tiefe in cm ein: ");
                double tiefe2 = Convert.ToDouble(Console.ReadLine());

                //Input the data into the "Truhe"
                truhen_array[i] = Eingabe(breite2, hoehe2, tiefe2);

                //Calculate the "Rohrlänge"
                summe += Berechnung_Rohrlaenge(truhen_array[i]);
            }

            //empty Line
            Console.WriteLine("");

            //Output the solution
            Console.WriteLine("Die Summe der Rohrlänge beträgt: {0} cm", summe);
        }
    }
}
