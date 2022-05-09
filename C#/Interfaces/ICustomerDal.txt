using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{   //Class implementation from file. Select Interface
    //Our project supports both Sql and Oracle databases.
    
    //Declare
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal //Lamb then implement missing members
    {
        //Define
        public void Add()
        {
            //Delete inside
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            //Delete inside
            Console.WriteLine("Sql Updated");
        }

        public void Delete()
        {
            //Delete inside
            Console.WriteLine("Sql Deleted");
        }
    }

    class MySqlCustomerDal : ICustomerDal //Lamb then implement missing members
    {
        //Define
        public void Add()
        {
            //Delete inside
            Console.WriteLine("MySql Added");
        }

        public void Update()
        {
            //Delete inside
            Console.WriteLine("MySql Updated");
        }

        public void Delete()
        {
            //Delete inside
            Console.WriteLine("MySql Deleted");
        }
    }

    class OracleCustomerDal : ICustomerDal //Lamb then implement missing members
    {
        //Define
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    
    class CustomerManager
    {
        //Define
        public void Add(ICustomerDal customerDal)//Method. Like member function of a class in C++.
        {
            //this method works for both Sql and Oracle databases
            customerDal.Add();
        }
    }

}
