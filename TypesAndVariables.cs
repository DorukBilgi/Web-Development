using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int     number1   = 2147483647;          // int max.
            long    number2   = 9223372036854775807; // long max.
            short   number3   = 32767;               // short max.
            byte    number4   = 255;                 // byte max.
            double  number5   = 10.4;
            decimal number6   = 10.4M;               //virgulden sonra 28,29 hane tutabilir.
            var     number7   = 10;                  // detect as integer
            number7           = 'A';                 //ASCII value of A to number7 (integer var)
            //number7           = "A";               //error 
            bool    condition = false;
            char    character = 'A';
            
            Console.WriteLine("Hello World!!!!");
            Console.WriteLine("Number1 is {0}" ,number1);
            Console.WriteLine("Number2 is {0}" ,number2);
            Console.WriteLine("Number3 is {0}" ,number3);
            Console.WriteLine("Number4 is {0}" ,number4);
            Console.WriteLine("Number5 is {0}" ,number5);
            Console.WriteLine("Number6 is {0}" ,number6);
            Console.WriteLine("Number7 is {0}" ,number7);
            Console.WriteLine("Condition is {0}" ,condition);
            Console.WriteLine("Character is {0} {1}" ,character,(int)character);//ASCII
            Console.WriteLine(Days.Friday);       
            Console.WriteLine((int)Days.Friday); // order of Friday
            
            Console.ReadLine();
        }
    }

    enum Days 
    {
        Monday=10, Tuesday=20, Wednesday=30,Thursday, Friday, Saturday, Sunday
    }


}
