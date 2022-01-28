using System;

namespace _20220117_Parameterübergabe1
{
    class Program
    {
        //Create function "Stringtausch"
        static void StringTausch(ref string text, ref string text2)
        {
            //Set the string text to antother value
            string speicher = text;
            text = text2;
            text2 = speicher;
        }

        static void Main(string[] args)
        {
            //Create a variable
            string text = "Hallo";
            string text2 = "Servus";

            //Vor dem Vertausch: Ausgabe
            Console.WriteLine("Die Strings vor dem Vertausch: ");
            Console.WriteLine("Der 1.String beinhaltet: " + text);
            Console.WriteLine("Der 2.String beinhaltet: " + text2);

            //Get switch the strings
            StringTausch(ref text, ref text2);

            //empty Line
            Console.WriteLine("");

            //Nach dem Vertausch: Ausgabe
            Console.WriteLine("Die Strings nach dem Vertausch: ");
            Console.WriteLine("Der 1.String beinhaltet: " + text);
            Console.WriteLine("Der 2.String beinhaltet: " + text2);
        }
    }
}
