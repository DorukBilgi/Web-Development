using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[3]
            {
                new Customer { FirstName = "Doruk"},
                new Person   { FirstName = "Burak"},
                new Student  { FirstName = "Tan" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; } //prop -> tab
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Interface'ten farklý olarak -> class Customer : Person, Person2 yazamayýz. Bir tane Büyük Balýk olmalý. Ama birden fazla implementasyon yapabiliriz.
    //Inheritance önce yazýlýr. Interface devamýna yazabilirsin.
    //Interfaceler daha mantýklý. Abstract kullanýrken Inheritance kullanýlmalý.

    class Customer : Person // Person is big fish. You can access to Person's methods. 
    {
        public string City { get; set; }
    }

    class Student : Person //Person is big fish. You can access to Person's methods.
    {
        public string Department { get; set; }
    }
}
