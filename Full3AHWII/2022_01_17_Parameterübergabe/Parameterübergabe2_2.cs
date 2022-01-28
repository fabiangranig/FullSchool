using System;

namespace _20220117_Parameterübergabe2
{
    class Program
    {
        //Create function "Kegelberechnen"
        static void Kegelberechnen(double radius, double hoehe, out double volumen, out double oberflaeche)
        {
            //Calculate the values
            volumen = (Math.PI * Math.Pow(radius, 2) * hoehe) / 3;
            double s = Math.Sqrt(Math.Pow(hoehe, 2) + Math.Pow(radius, 2));
            oberflaeche = Math.PI * Math.Pow(radius, 2) + Math.PI * radius * s;
        }

        static void Main(string[] args)
        {
            //Instruction
            Console.WriteLine("Mit diesem Kegel lässt sich das Volumen und die Oberfläche eines Kegels berechnen.");

            //Input the data
            Console.Write("Bitte geben Sie den Radius ein: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die Höhe ein: ");
            double hoehe = Convert.ToDouble(Console.ReadLine());

            //Create the variable for "volume" und "oberflaeche"
            double volumen;
            double oberflaeche;

            //function "Kegelberechnen"
            Kegelberechnen(radius, hoehe, out volumen, out oberflaeche);

            //empty Line
            Console.WriteLine("");

            //Output the solution
            Console.WriteLine("Das Ergebnis ist:");
            Console.WriteLine("Oberfläche: " + Math.Round(oberflaeche, 2));
            Console.WriteLine("Volumen: " + Math.Round(volumen, 2));
        }
    }
}
