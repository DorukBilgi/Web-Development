using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //customerManager object
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //Declare type 1 property in class
            Customer customer  = new Customer();
            customer.City      = "Ankara"; // run "set" block of property
            customer.ID        = 1;
            customer.FirstName = "Doruk";
            customer.LastName  = "Bilgi";

            //Declare type 2 for property in class
            Customer customer2 = new Customer
            {
               City = "Ýstanbul" , ID = 2 ,FirstName = "Tan",LastName = "Bilgi"  // ctrl + space
            };

            Console.WriteLine(customer2.FirstName); // run "get" block of property

            Console.ReadLine();
        }
    }


    
}
