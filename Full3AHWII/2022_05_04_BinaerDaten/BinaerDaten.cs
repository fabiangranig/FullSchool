//Beispiel: Binär Dateien
//04.05.2022
//Fabian Granig 3AHWII
using System;
using System.IO;

namespace _20220504_BinaerDaten
{
    class Program
    {
        static void BinaerWrite()
        {
            FileStream myStream = new FileStream("Test.Dat", FileMode.Create);
            BinaryWriter Writer = new BinaryWriter(myStream);

            for (int i = 0; i < 100; i++)
            {
                string Bez = "Hallo" + i.ToString();

                int Z = i;

                double D = (double)i / 12.0;

                Writer.Write(Bez);
                Writer.Write(Z);
                Writer.Write(D);
            }

            Writer.Close();
            myStream.Close();
        }

        static void BinaerRead()
        {
            FileStream myStream = new FileStream("Test.Dat", FileMode.Open);
            BinaryReader Reader = new BinaryReader(myStream);

            while (Reader.PeekChar() > -1)
            {
                string Bez = Reader.ReadString();
                int Z = Reader.ReadInt32();
                double D = Reader.ReadDouble();

                Console.WriteLine(Bez);
                Console.WriteLine(Z);
                Console.WriteLine(D);
                Console.WriteLine("-----------------------");
            }

            Reader.Close();
            myStream.Close();
        }

        static void Main(string[] args)
        {
            BinaerRead();
        }
    }
}
