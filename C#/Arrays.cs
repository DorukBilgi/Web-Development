using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 dimension array
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Saih";

            //string[] students = new string[3]{ "Engin", "Derin", "Salih" }; //same
            //string[] students = { "Engin", "Derin", "Salih" };              //same
            //error: students[3] = "Ahmet"; 4th element cannot assigned to 3-variable array

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-----------");

            //2 dimension array
            string[,] regions = new string[5, 3] //7 row,3 column
            {
                { "Ýstanbul", "Ýzmir", "Balýkesir" },
                { "Ankara", "Konya", "Kýrýkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "Ýzmir", "Muðla", "Manisa" }

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("************");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

}
