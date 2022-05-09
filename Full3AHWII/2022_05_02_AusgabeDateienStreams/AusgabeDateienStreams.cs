using System;
using System.IO;

namespace _20220502_AusgabeDateienStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("K:/text.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < 20; i++)
            {
                sw.WriteLine(Convert.ToString(i));
            }

            sw.Close();
            fs.Close();
        }
    }
}
