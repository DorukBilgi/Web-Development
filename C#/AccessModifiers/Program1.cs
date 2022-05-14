using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example for internal vs public/ protected vs private.
namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }

    class Customer
    {
        protected int Id { get; set; }//Protected privateın bütün özelliklerini kapsıyor.
        //(private) access only from defined class. Protected dersek inheritance seviyesinde kullanabiliriz.
        public void Save()
        {


        }

        public void Delete()
        {


        }
    }

    class Student:Customer//inheritance
    {
        public void Save2()
        {


        }
    }

    //bir class ya public olabilir ya da internal olabilir. Class içinde başka bir class private olabilir.
    public class Course// internal type olmasaydı ClassManager classın içinde kullanamazdık. Proje içerisindeki diğer classlar tarafından kullanabilmesi için internal tanımlanır.
    {
        public string Name { get; set; }
    }
    // internal yazmak zorunlu değildir.

    //Farklı bir projeden (AccessModifiersDemo) almak istersek... bu class public tanımlanmalı internal değil.
}
