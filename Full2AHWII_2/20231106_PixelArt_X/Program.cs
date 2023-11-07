using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _20231106_PixelArt_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlyOneIf(20);
        }

        static void NoIf(int size)
        {
            
        }

        static void OnlyOneIf(int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (x == y || size - 1 - y == x)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
