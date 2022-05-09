using System;
using System.IO;

namespace _20220502_EingabeDateienStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream zeichen = new FileStream("K:/text.txt", FileMode.Open);
            StreamReader lesen = new StreamReader(zeichen);

            string zeilen = " ";
            while (zeilen != null)
            {
                zeilen = lesen.ReadLine();
                Console.WriteLine(zeilen);
            }

            lesen.Close();
        }
    }
}
