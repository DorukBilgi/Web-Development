using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database(); //Error: Abstracts cannot be new.
            Database database1 = new Oracle();
            database1.Add(); // Added by default
            database1.Delete(); // Deleted by oracle

            Database database2 = new SqlServer();
            database2.Add(); // Added by default
            database2.Delete(); // Deleted by sql

            Console.ReadLine();
        }
    }

    abstract class Database
    {

        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();

    }

    class SqlServer : Database // Lamb then implement missing parts. Override olarak gelir. Sadece delete method geldi.
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql"); 
        }
    }

    class Oracle : Database // Lamb then implement missing parts. Override olarak gelir. Sadece delete method geldi.
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
