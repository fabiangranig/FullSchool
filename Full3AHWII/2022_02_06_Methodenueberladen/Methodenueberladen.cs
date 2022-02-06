//Fabian Granig 3AHWII
//06.02.2022
//Beispiel: Punkt2D /  Methoden überladen
using System;

namespace _20220206_Punkt2D
{
    class Punkt2D
    {
        //Variables for the class
        public double X;
	public double Y;

	//Standart Konstruktor1
	public Punkt2D()
	{
		this.X = 0;
		this.Y = 0;
	}

	//X, Y Konstruktor
	public Punkt2D(double X1, double Y1)
	{
		this.X = X1;
		this.Y = Y1;
	}

	//X Konstruktor
	public Punkt2D(double X1)
	{
		this.X = X1;
		this.Y = X1;
	}

        //function to move the inputed data to the Punkt2D
        public void PunktEinlesen(double x, double y)
        {
            //Put the values in the Punkt2D struct
            this.X = x;
            this.Y = y;
        }

        //function to output the data into the console
        public void PunktAusgeben()
        {
            //Output with CW
            Console.WriteLine("Die X-Kordinate beträgt: {0}", this.X);
            Console.WriteLine("Die Y-Kordinate beträgt: {0}", this.Y);
        }

        //function to get the distance between two point
        public double Laenge(Punkt2D punkt2)
        {
            //Calculate with the formular
            double laenge = Math.Sqrt(Math.Pow(this.X - punkt2.X, 2) + Math.Pow(this.Y - punkt2.Y, 2));

            //Return the value
            return laenge;
        }

        //function to get the mid of two point
        public Punkt2D GeradeMittelpunkt(Punkt2D punkt2)
        {
            //Declare a temp Punkt2D
            Punkt2D punkt2D_temp = new Punkt2D();

            //Calculate the mid point with the formular
            punkt2D_temp.X = (this.X + punkt2.X) / 2;
            punkt2D_temp.Y = (this.Y + punkt2.Y) / 2;

            //Return the value
            return punkt2D_temp;
        }

        //function to get the "Steigung"
        public double Steigung(Punkt2D punkt2)
        {
            //Calculate "Steigung"
            double steigung = (punkt2.Y - this.Y) / (punkt2.X - this.X);

            //return the solution
            return steigung;
        }

	//function Mul with point
	public Punkt2D Mul(Punkt2D punkt2)
	{
		//Create a new temp punkt
		Punkt2D punkt3 = new Punkt2D();
		
		//Calculation
		punkt3.X = this.X * punkt2.X;
		punkt3.Y = this.Y * punkt2.Y;

		//Return the punkt
		return punkt3;
	}

	//function Mul with lenth
	public Punkt2D Mul(double length1)
	{
		//Create a new punkt
		Punkt2D punkt3 = new Punkt2D();

		//Calculation
		punkt3.X = this.X * length1;
		punkt3.Y = this.Y * length1;

		//Return the solution
		return punkt3;
	}
    }

    class Program
    {
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
            Punkt2D punkt1 = new Punkt2D(X_Cord1, Y_Cord1);
	    Punkt2D punkt2 = new Punkt2D(X_Cord2, Y_Cord2);

            //empty Line
            Console.WriteLine(" ");

            //Give back the cordinates with function "PunktAusgeben"
            Console.WriteLine("Punkt1 Ausgabe:");
            punkt1.PunktAusgeben();

            //empty Line
            Console.WriteLine(" ");

            //Give back the second cordinates with function "PunktAusgeben"
            Console.WriteLine("Punkt2 Ausgabe: ");
            punkt2.PunktAusgeben();

            //empty Line
            Console.WriteLine(" ");

            //get the "Laenge" of the two points with the function "Laenge"
            double laenge = punkt1.Laenge(punkt2);
            Console.WriteLine("Die Länge beträgt: {0}", laenge);

            //get the mid point of those two points
            Punkt2D mid_point = punkt1.GeradeMittelpunkt(punkt2);
            Console.WriteLine("Der Mittelpunkt ist der Punkt ({0} / {1})", mid_point.X, mid_point.Y);

            //get the "Steigung"
            double steigung = punkt1.Steigung(punkt2);

            Console.WriteLine("Die Steigung beträgt: {0}", steigung);

	    //empty Line
	    Console.WriteLine("");

	    //Mul point * point
	    Console.WriteLine("Two point multiplied:");
	    Punkt2D punkt3 = punkt1.Mul(punkt2);
	    punkt3.PunktAusgeben();

	    //Mul point * length
	    Console.WriteLine("Point multiplied with length:");
	    Console.Write("Bitte die Länge eingeben: ");
	    double length = Convert.ToDouble(Console.ReadLine());
	    Punkt2D punkt4 = punkt1.Mul(length);
	    punkt4.PunktAusgeben();
        }
    }
}
