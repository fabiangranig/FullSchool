using System;

namespace _2022_09_20_Einfuehrung
{
    class Program
    {
        class Zahl1
        {
            protected int Wert;

            public Zahl1()
            {
                this.Wert = 5;
            }

            public Zahl1(int w)
            {
                this.Wert = w;
            }

            public void Ausgabe()
            {
                Console.WriteLine(this.Wert);
            }

        }

        class Zahl2 : Zahl1
        {
            public Zahl2(int w):base(w)
            {
            }

            public void Eingabe(int i)
            {
                this.Wert = i;
            }
        }


        static void Main(string[] args)
        {
            int w = 2;
            Zahl2 eineZahl = new Zahl2(w);
            eineZahl.Ausgabe();
            eineZahl.Eingabe(10);
            eineZahl.Ausgabe();
        }
    }
}
