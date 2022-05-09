using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Demo_2 // Proffessional Abstarction
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger(); //Logged to file! or change it to database/SMS
            customerManager.Add(); // Customer Added!
            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class CustomerManager
    {
        public ILogger Logger{ get; set; } // prop then tab. Property for set.
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SMSLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }
}
