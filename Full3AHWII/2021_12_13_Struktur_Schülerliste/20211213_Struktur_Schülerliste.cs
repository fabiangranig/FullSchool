//Fabian Granig 3AHWII
//13.12.2021
//Struktur: Schülerliste

using System;

namespace _20211213_Struktur_Schülerliste
{
    class Program
    {
        //Create Struct "Schueler"
        struct Schueler
        {
            public int KatNr;
            public string Vorname;
            public string Nachname;
            public int Alter;
        }

        //Function "Eingabe"
        static Schueler Eingabe()
        {
            //Create an pseudo Schueler for return
            Schueler schueler;

            //Input the data
            Console.Write("Geben Sie bitte die KatNr ein: ");
            schueler.KatNr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie bitte den Vornamen ein: ");
            schueler.Vorname = Convert.ToString(Console.ReadLine());
            Console.Write("Geben Sie bitte den Nachnamen ein: ");
            schueler.Nachname = Convert.ToString(Console.ReadLine());
            Console.Write("Geben Sie bitte das Alter ein: ");
            schueler.Alter = Convert.ToInt32(Console.ReadLine());

            //Return "schueler"
            return schueler;
        }

        //Function "Anzeigen"
        static void Anzeigen(Schueler schueler)
        {
            //Write the values into the console
            Console.WriteLine("Der Schüler hat die {0}.KatNr", schueler.KatNr);
            Console.WriteLine("Der Schüler hat den Vornamen: {0}", schueler.Vorname);
            Console.WriteLine("Der Schüler hat den Nachnamen: {0}", schueler.Nachname);
            Console.WriteLine("Der Schüler ist {0}.Jahre alt.", schueler.Alter);
        }

        //Function "GetVorUndNachname"
        static string GetVorUndNachname(Schueler schueler)
        {
            //Put the First uhd Last Name togheter
            string solution = schueler.Vorname + " " + schueler.Nachname;

            //Return the solution
            return solution;
        }

        //Function "MaxAlter"
        static Schueler MaxAlter(Schueler[] Klasse)
        {
            //Check with for and if which "Alter" is the biggest
            int i_count_stopper = -1;
            int highest_alter = -1;
            for(int i = 0; i < Klasse.Length; i++)
            {
                if(Klasse[i].Alter > highest_alter)
                {
                    highest_alter = Klasse[i].Alter;
                    i_count_stopper = i;
                }
            }

            //Return the "Schueler"
            return Klasse[i_count_stopper];
        }

        static void Main(string[] args)
        {
            //Input the information for schueler1
            Schueler schueler1 = Eingabe();

            //empty Line
            Console.WriteLine(" ");

            //Output the values wiht the function "Anzeigen"
            Anzeigen(schueler1);

            //Put the "Vorname" and the "Nachname" in an String togheter
            string vor_und_nachname = GetVorUndNachname(schueler1);
            Console.WriteLine("Der Schüler heißt {0}.", vor_und_nachname);

            //Empty Line
            Console.WriteLine(" ");

            //Create an Array "Schulklasse"
            Schueler[] Schulklasse = new Schueler[5];

            //Loop in the Array
            for(int i = 0; i < Schulklasse.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Eingabe {0}.Schüler: ", i+1);
                Schulklasse[i] = Eingabe();
            }

            //empty Line
            Console.WriteLine(" ");

            //Retrieve the information from the array
            for (int i = 0; i < Schulklasse.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ausgabe {0}.Schüler: ", i + 1);
                Anzeigen(Schulklasse[i]);
            }

            //empty Line
            Console.WriteLine(" ");

            //MaxAlter return
            Schueler schueler_max_Alt = MaxAlter(Schulklasse);

            //Output all values from the oldest schueler
            Console.WriteLine("Der älteste Schüler: ");
            Anzeigen(schueler_max_Alt);
        }
    }
}
