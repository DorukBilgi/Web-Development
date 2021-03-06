using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2); // Output: 10

            string[] cities1 = new string[]{"Ankara","Adana","Afyon"};  //101
            string[] cities2 = new string[]{"Bursa","Bolu","Balýkesir"};//102
            cities2 = cities1;//Delete 102 write 101. (Memory deallocation) in C# Garbage Collector.
            cities1[0] = "Ýstanbul";
            Console.WriteLine(cities2[0]); // Output: Ýstanbul (passed-by-reference)

            // DataTable dataTable = new DataTable();
            DataTable dataTable; // unnecessary for typing "new"...
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
