using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2]{"Ankara","Ýstanbul"};
            ////cities[2] = "Adana";//Error: third element
            ////cities[1] = "Adana";//Second element.
            // cities = new string[3];//"new" dedikten sonra içi boþaldý.
            // Console.WriteLine(cities[0]);// Output: null.

            ArrayList();   //First write inside main then refactor -> extract -> extract method.
            List();        //First write inside main then refactor -> extract -> extract method.
            Dictionaryy(); //First write inside main then refactor -> extract -> extract method.

            Console.ReadLine();
        }

        private static void Dictionaryy()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
        }

        private static void List()
        {
            //with type def. Tip güvenli.
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Ýstanbul");

            Console.WriteLine(cities.Contains("Ankara")); // If contains, output is true.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //with type def. Tip güvenli from class.

            //1.
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer{Id=1, FirstName = "Doruk"});
            //customers.Add(new Customer{Id=2, FirstName = "Burak"});

            //2.
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Id = 1, FirstName = "Doruk" },
                new Customer { Id = 2, FirstName = "Burak" }
            };

            var customer2 = new Customer
            {
                Id = 3, FirstName = "Fatih"
            };
            customers.Add(customer2); //Adding new customer.

            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4, FirstName = "Ali" },
                new Customer { Id = 5, FirstName = "Ahmet" }
            }); //Adding new customers.


            //customers.Insert(0,customer2);// inserting customers to desired index.

            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);

            //customers.RemoveAll(c=>c.FirstName == "Fatih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
            }

            //customers.Clear(); // Deleting all customers.

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index: {0}", index2);
        }

        private static void ArrayList()
        {
            //without type def. Tip güvenli deðil.
            ArrayList cities = new ArrayList(); // Collections. You can add more elements to this non-sized array.
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("Ýstanbul"); // Add 3rd element to array.
            cities.Add(1); // Add 4th element to array.
            cities.Add('A'); // Add 5th element to array.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        class Customer
        {
            public int Id { get; set; }           //Prop then tab.
            public string FirstName { get; set; } //Prop then tab.
        }
    }
}
