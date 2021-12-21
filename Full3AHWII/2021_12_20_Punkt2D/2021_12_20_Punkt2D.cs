//Fabian Granig 3AHWII
//20.12.2021
//Beispiel Punkt2D
using System;

namespace _20211220_Punkt2D
{
    class Program
    {
        //structur "cordinates"
        struct Punkt2D
        {
            public double X;
            public double Y;
        }

        //function to move the inputed data to the Punkt2D
        static Punkt2D PunktEinlesen(double x, double y)
        {
            //Create a new Punkt2D struct
            Punkt2D punkt;

            //Put the values in the Punkt2D struct
            punkt.X = x;
            punkt.Y = y;

            //Return the Punkt2D struct
            return punkt;
        }

        //function to output the data into the console
        static void PunktAusgeben(Punkt2D punkt)
        {
            //Output with CW
            Console.WriteLine("Die X-Kordinate beträgt: {0}", punkt.X);
            Console.WriteLine("Die Y-Kordinate beträgt: {0}", punkt.Y);
        }

        //function to get the distance between two point
        static double Laenge(Punkt2D punkt1, Punkt2D punkt2)
        {
            //Calculate with the formular
            double laenge = Math.Sqrt(Math.Pow(punkt1.X - punkt2.X, 2) + Math.Pow(punkt1.Y - punkt2.Y, 2));

            //Return the value
            return laenge;
        }

        //function to get the mid of two point
        static Punkt2D GeradeMittelpunkt(Punkt2D punkt1, Punkt2D punkt2)
        {
            //Declare a temp Punkt2D
            Punkt2D punkt2D_temp;

            //Calculate the mid point with the formular
            punkt2D_temp.X = (punkt1.X + punkt2.X) / 2;
            punkt2D_temp.Y = (punkt1.Y + punkt2.Y) / 2;

            //Return the value
            return punkt2D_temp;
        }

        //function to get the "Steigung"
        static double Steigung(Punkt2D punkt1, Punkt2D punkt2)
        {
            //Calculate "Steigung"
            double steigung = (punkt2.Y - punkt1.Y) / (punkt2.X - punkt1.X);

            //return the solution
            return steigung;
        }

        static void Main(string[] args)
        {
            //Input the data1
            Console.WriteLine("Punkt1 Eingabe: ");
            Console.Write("Geben Sie bitte die X-Cordinate ein: ");
            double X_Cord1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie bitte die Y-Cordinate ein: ");
            double Y_Cord1 = Convert.ToDouble(Console.ReadLine());

            //empty Line
            Console.WriteLine(" ");

            //Input the data2
            Console.WriteLine("Punkt2 Eingabe: ");
            Console.Write("Geben Sie bitte die X-Cordinate ein: ");
            double X_Cord2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie bitte die Y-Cordinate ein: ");
            double Y_Cord2 = Convert.ToDouble(Console.ReadLine());

            //Apply function "PunktEinlesen"
            Punkt2D Cordinates_1 = PunktEinlesen(X_Cord1, Y_Cord1);
            Punkt2D Cordinates_2 = PunktEinlesen(X_Cord2, Y_Cord2);

            //empty Line
            Console.WriteLine(" ");

            //Give back the cordinates with function "PunktAusgeben"
            Console.WriteLine("Punkt1 Ausgabe:");
            PunktAusgeben(Cordinates_1);

            //empty Line
            Console.WriteLine(" ");

            //Give back the second cordinates with function "PunktAusgeben"
            Console.WriteLine("Punkt2 Ausgabe: ");
            PunktAusgeben(Cordinates_2);

            //empty Line
            Console.WriteLine(" ");

            //get the "Laenge" of the two points with the function "Laenge"
            double laenge = Laenge(Cordinates_1, Cordinates_2);
            Console.WriteLine("Die Länge beträgt: {0}", laenge);

            //get the mid point of those two points
            Punkt2D mid_point = GeradeMittelpunkt(Cordinates_1, Cordinates_2);
            Console.WriteLine("Der Mittelpunkt ist der Punkt ({0} / {1})", mid_point.X, mid_point.Y);

            //get the "Steigung"
            double steigung = Steigung(Cordinates_1, Cordinates_2);
            Console.WriteLine("Die Steigung beträgt: {0}", steigung);
        }
    }
}
