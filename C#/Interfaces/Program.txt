using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args) //Like main function in C++ OOP.
        {
            InterfacesIntro();//RightClick -> Refactor -> extract method.

            //IPerson person = new IPerson();// error.
            //IPerson person = new Customer();// it is ok.

            Demo();//RightClick -> Refactor -> extract method.

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            
            Console.ReadLine();
        }

        private static void Demo()
        {
            //Other interface(ICustomerDal) for this project.(Added from docs)
            CustomerManager customerManager1 = new CustomerManager();
            CustomerManager customerManager2 = new CustomerManager();
            customerManager1.Add(new SqlServerCustomerDal());
            customerManager2.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            //Declare,Define,"Use" Algorithm. 
            PersonManager manager = new PersonManager(); //Manager is big fish.

            Customer customer = new Customer() //customer is IPerson
            {
                Id = 1,
                FirstName = "Doruk",
                LastName = "Bilgi",
                Address = "Ankara"
            };
            manager.Add(customer);

            Student student = new Student() //Student is IPerson
            {
                Id = 1,
                FirstName = "Tan",
                LastName = "Bilgi",
                Department = "Engineering"
            };
            manager.Add(student);
        }
    }

    //Declare
    interface IPerson
    {

        int Id { get; set; } //prop -> tab. 
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson // Lamb then click implement missing members
    {
        //Define
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; } //add manually. prop then click tab
    }

    class Student : IPerson // Lamb then click implement missing members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; } //add manually. prop then click tab
    }

    class Worker : IPerson // Lamb then click implement missing members
    {
        //Define
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; } //add manually. prop then click tab
    }

    
    class PersonManager //This works for both "customer" and "student".
    {
        //Define
        public void Add(IPerson person)//Method. Like member function of a class in C++.
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
