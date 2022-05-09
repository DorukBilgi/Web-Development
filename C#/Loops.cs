using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();     // right click -> refactor this -> extract method (resharper needed)
            //WhileLoop();   // right click -> refactor this -> extract method (resharper needed)
            //DoWhileLoop(); // right click -> refactor this -> extract method (resharper needed)
            //ForEachLoop(); // right click -> refactor this -> extract method (resharper needed)

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a Prime Number.");
            }
            else
            {
                Console.WriteLine("This is NOT a Prime Number.");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number; //break 
                }

            }
            return result;
        }



        //Loop methods
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Doruk", "Ali" };
            foreach (var student in students)
            {
                //student = "Ahmet";
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now number is {0}", number); //-1
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }
    }
}
