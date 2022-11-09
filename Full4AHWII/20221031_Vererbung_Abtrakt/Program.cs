using System;

namespace _20221031_Vererbung_Abtrakt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dreieck
            Console.WriteLine("Dreieck: 10*20");
            Dreieck dreieck1 = new Dreieck(11.9, 11.2);
            Console.WriteLine(dreieck1.ToString());
            Console.WriteLine("Umfang: " + dreieck1.umfang());
            Console.WriteLine("Fläche: " + dreieck1.flaeche());

            //leere Zeile
            Console.WriteLine("");

            //Ellipse
            Console.WriteLine("Ellipse: 10*20");
            Ellipse ellipse1 = new Ellipse(10, 20, "Grün");
            Console.WriteLine(ellipse1.ToString());
            Console.WriteLine("Umfang: " + ellipse1.umfang());
            Console.WriteLine("Fläche: " + ellipse1.flaeche());

            //leere Zeile
            Console.WriteLine("");

            //Kreis
            Console.WriteLine("Kreis: r=20");
            Kreis kreis1 = new Kreis(20, "Gelb");
            Console.WriteLine(kreis1.ToString());
            Console.WriteLine("Umfang: " + kreis1.umfang());
            Console.WriteLine("Fläche: " + kreis1.flaeche());

            //leere Zeile
            Console.WriteLine("");

            //Viereck
            Console.WriteLine("Viereck: 10*20");
            Viereck viereck1 = new Viereck(10, 20);
            Console.WriteLine(viereck1.ToString());
            Console.WriteLine("Umfang: " + viereck1.umfang());
            Console.WriteLine("Fläche: " + viereck1.flaeche());

            //leere Zeile
            Console.WriteLine("");

            //Quadrat
            Console.WriteLine("Quadrat: a=10");
            Quadrat quadrat1 = new Quadrat(10);
            Console.WriteLine(quadrat1.ToString());
            Console.WriteLine("Umfang: " + quadrat1.umfang());
            Console.WriteLine("Fläche: " + quadrat1.flaeche());
        }
    }
}
