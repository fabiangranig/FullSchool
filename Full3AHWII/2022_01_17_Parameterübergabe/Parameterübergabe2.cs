using System;

namespace _20220117_Parameterübergabe2
{
    class Program
    {
        //struct Kegel
        struct Kegel
        {
            public double radius;
            public double hoehe;
            public double volumen;
            public double oberflaeche;
        }

        //Create function "Kegelberechnen"
        static void Kegelberechnen(ref Kegel kegel)
        {
            //Calculate the values
            kegel.volumen = (Math.PI * Math.Pow(kegel.radius, 2) * kegel.hoehe) / 3;
            double s = Math.Sqrt(Math.Pow(kegel.hoehe, 2) + Math.Pow(kegel.radius, 2));
            kegel.oberflaeche = Math.PI * Math.Pow(kegel.radius, 2) + Math.PI * kegel.radius * s;
        }

        static void Main(string[] args)
        {
            //Create a Kegel
            Kegel kegel;

            //Instruction
            Console.WriteLine("Mit diesem Kegel lässt sich das Volumen und die Oberfläche eines Kegels berechnen.");

            //Input the data
            Console.Write("Bitte geben Sie den Radius ein: ");
            kegel.radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie die Höhe ein: ");
            kegel.hoehe = Convert.ToDouble(Console.ReadLine());

            //Set the other two values to zero
            kegel.volumen = 0;
            kegel.oberflaeche = 0;

            //function "Kegelberechnen"
            Kegelberechnen(ref kegel);

            //empty Line
            Console.WriteLine("");

            //Output the solution
            Console.WriteLine("Das Ergebnis ist:");
            Console.WriteLine("Oberfläche: " + kegel.oberflaeche);
            Console.WriteLine("Volumen: " + kegel.volumen);
        }
    }
}
