using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro(); //refactor this. 

            //1)With Try.
            try
            {
                OurException(); //refactor this. 
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //2)With Method.
            //Lamb then click generate method.
            HandleException(() =>
            {
                OurException(); //refactor this.
            });

            
            Console.ReadLine();//1 and 2 same result.

        }

        private static void HandleException(Action action)
        {
           // throw new NotImplementedException(); // Comment or delete this.
           try
           {
                action.Invoke(); //OurException'ý çalýþtýr.
           }
           catch (Exception exception)
           {
               Console.WriteLine(exception.Message);
           }
        }

        private static void OurException()
        {
            List<string> students = new List<string> { "Doruk", "Burak", "Tan" };

            if (!students.Contains("Ahmet")) // Ahmet yoksa hata fýrlat.
            {
                throw new RecordNotFoundException("Record Not Found!!"); // Constructor sayesinde desired message given.
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try //Type "try" then tab. Delete "throw" command.
            {
                string[] students = new string[3] { "Doruk", "Burak", "Tan" };
                students[3] = "Fatih";
            }
            catch (IndexOutOfRangeException exception) //Hata yakalýyor.
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception) //Hata yakalýyor.
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) //Hata yakalýyor.
            {
                Console.WriteLine(exception.Message); //try bloðunun neden çalýþmadýðýný çýkýþ olarak veriyor.
            }
        }
    }
}
