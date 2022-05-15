using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();       // Output:15 (Default Constructor)
            CustomerManager customerManager = new CustomerManager(24); // Output:24 
            customerManager.List();

            //1. YOL (property)
            Product product1 = new Product { Id = 1, Name = "Laptop" };//Set id and name.
            Console.WriteLine(product1.Id);                            //Get id.
            Console.WriteLine(product1.Name);                          //Get name.

            //2. YOL (Constructors)
            Product product2 = new Product(2, "Computer");
            product2.List();

            //Interface usage for logging file or database.

            //1. YOL (property)
            //EmployeeManager employeeManager = new EmployeeManager();
            //employeeManager.Logger = new FileLogger(); // Logged to ...
            //employeeManager.Add1(); // Added!

            //2. YOL (Constructors)
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());// Logged to ...
            employeeManager.Add(); // Added!

            PersonManager personManager = new PersonManager("Product");// Product message.
            personManager.Add(); // Added!


            //Static objects.

            //Teacher teacher = new Teacher(); // Error.
            Teacher.Number = 10; // Use Static objects like this. Set method.
            Utilities.Validate();// Use Static objects methods like this.
            
            // Usage of static method for non-static class.
            Manager.DoSomething();

            // Usage of non-static method for non-static class. (Normal usage)
            Manager manager = new Manager();
            manager.DoSomething2();


            Console.ReadLine();
        }

    }

    class CustomerManager
    {

        private int _count = 15; // Member variable.

        public CustomerManager() // Default constructor.
        {

        }

        public CustomerManager(int count) // Constructor. Type "ctor" then tab. Constructor Overloading.
        {
            _count = count;
        }

        public void List()// Method Like Member Function.
        {
            Console.WriteLine("Listed! {0} items", _count);
        }

        public void Add() // Method Like Member Function.
        {
            Console.WriteLine("Added!");
        }

    }

    class Product
    {
        //1. YOL (property)
        public int Id { get; set; }// Type prop then tab.
        public string Name { get; set; }// Type prop then tab.

        //2. YOL (Constructor)
        public Product()  // Default Constructor.
        {

        }

        private int _id;
        private string _name;

        public Product(int id, string name) // Constructor with parameters
        {
            _id = id;
            _name = name;
        }

        public void List()// Method Like Member Function.
        {
            Console.WriteLine("{0}", _id);
            Console.WriteLine("{0}", _name);
        }

    }

    //"Interface" usage for logging. Basic.
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");

        }
    }

    class FileLogger : ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        //1. YOL (property)
        //public ILogger Logger { get; set; } // Property for logging(ILogger interface type).
        //public void Add() //Method for adding.
        //{
        //    Logger.Log();
        //    Console.WriteLine("Added!");
        //}

        //2. YOL (Constructor)
        private ILogger _logger;
        public EmployeeManager(ILogger logger) //type ctor than tab
        {
            _logger = logger;
        }
        public void Add() //Method for adding.
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }

    }

    //"Inheritance" usage for logging. Basic.
    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity) // Type ctor than tab.
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }

    }

    class PersonManager : BaseClass 
    {
        public PersonManager(string entity):base(entity) // Send entity to "base" class. Initialization list for constructor. 
        {
           
        }

        public void Add() //Method for adding.
        {
            Console.WriteLine("Added!");
            Message(); // inherited method from base class.
        }

    }

    // Static. Difference of static/non-static.

    static class Teacher
    {
        public static int Number { get; set; } // Type prop than tab. Must type static for static objects.
    }

    static class Utilities
    {
        static Utilities() // Static constructor declare.
        {
            
        }

        public static void Validate() //Must type static for static object's method.
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething() // Static method for non-static class.
        {
            Console.WriteLine("Done!");
        }

        public void DoSomething2() // Non-static method for non-static class.
        {
            Console.WriteLine("Done 2!");
        }

    }

}
