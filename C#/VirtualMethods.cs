using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }

        class DataBase
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : DataBase // Inheritance
        {
            public override void Add() // virtual kullandýk fakat override edebiliriz bu sekilde.
            {
                Console.WriteLine("Added by Sql Code");
                //base.Add();
            }

        }

        class MySql : DataBase // Inheritance
        {



        }
    }
}
