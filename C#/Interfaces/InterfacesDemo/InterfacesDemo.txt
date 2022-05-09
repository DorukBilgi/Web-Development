using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Use
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()

            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    //Declare. SOL"I"D, Interface Segregation, More than one interface implementation.
    interface IWorker
    {
        //All workers
        void Work();
        //void Eat();
        //void GetSalary();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary  //lamb then implement missing members
    {
        //Define
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary //lamb then implement missing members
    {
        //Define
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker // Robot does not eat and not get salary
    {
        //Define
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

}
