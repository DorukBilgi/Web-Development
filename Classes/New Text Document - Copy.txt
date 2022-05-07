using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Customer class in different file (property)
namespace Classes
{
    class Customer
    {
        //Field in class
        //public string FirstName;//it also works (without get/set block). But differs in Encapsulation method. 

        //Property in class, prop -> tab (getter, setter functions like in c++)
        public int ID { get; set; }
        public string FirstName { get; set; }

        //Basic logic of encapsulation.
        //private string _firstName;
        //public string FirstName
        //{
        //    get { return "Mr." + _firstName; }
        //    set { _firstName = value; }
        //} 

        public string LastName { get; set; }
        public string City { get; set; }
    }
}
