using System;

namespace _20221114_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objekte deklarieren
            Cube cb = new Cube("Würfel", 10);
            Zylinder cy = new Zylinder("Zylinder", 15, 23);

            //Würfel ausgeben
            Console.WriteLine("Würfel hat folgende Werte: ");
            PrintValues(cb);

            //leere Zeile
            Console.WriteLine("");

            //Zylinder ausgeben
            Console.WriteLine("Zylinder hat folgende Werte: ");
            PrintValues(cy);
        }

        static void PrintValues(IGeometric geometric)
        {
            Console.WriteLine("Fläche: " + geometric.GetArea() + " Umfang: " + geometric.GetCircum() + " Volumen: " + geometric.GetVolume());
        }
    }
}
