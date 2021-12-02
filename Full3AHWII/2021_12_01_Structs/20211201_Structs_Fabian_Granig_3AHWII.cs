//01.12.2021
//Fabian Granig 3AHWII
//Structs Beispiel
using System;

namespace _20211201_Structs_Fabian_Granig_3AHWII
{
    class Program
    {
        struct Car
        {
            public string Brand;
            public string Model;
            public int Year;
            public float Price;
        }

        struct Employee
        {
            public string Firstname;
            public string Lastname;
            public float HourlyWage;
            public bool completedTraining;
        }

        static void Main(string[] args)
        {
            //What they are
            //  *custom data typ
            //Example Car
            //  * Brand - string
            string Brand;
            //  * Model - string
            string Model;
            //  * Year  - int
            int Year;
            //  * Price - float
            float Price;

            //Eingabe ohne Structs
            Console.Write("What's the Brand? ");
            Brand = Console.ReadLine();
            Console.Write("What's the Model? ");
            Model = Console.ReadLine();
            Console.Write("What's the Year? ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("What's the Price? ");
            Price = float.Parse(Console.ReadLine());

            //Deklarieren eines Structs
            Car car1;
            Car car2;
            Car car3;
            
            //Eingabe eines Structs
            Console.Write("What's the Brand? ");
            car1.Brand = Console.ReadLine();
            Console.Write("What's the Model? ");
            car1.Model = Console.ReadLine();
            Console.Write("What's the Year? ");
            car1.Year = int.Parse(Console.ReadLine());
            Console.Write("What's the Price? ");
            car1.Price = float.Parse(Console.ReadLine());

            //Erstellenen der Arbeiter
            Employee employee1;

            //Zuweisung zu der Structs
            employee1.Firstname = "Nicholas";
            employee1.Lastname = "Dingle";
            employee1.HourlyWage = 35.7f;
            employee1.completedTraining = true;
        }
    }
}
