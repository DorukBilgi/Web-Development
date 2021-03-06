using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            var result1 = Add2(20, 30);
            Console.WriteLine(result1);

            var result2 = Add3(4);
            Console.WriteLine(result2);

            int number1 = 20;
            int number2 = 100;

            var result3 = Add4(number1, number2);
            Console.WriteLine(result3);
            //not changed by its reference so number1 is not affected by method
            Console.WriteLine(number1); //20

            var result4 = Add5(ref number1, number2);
            Console.WriteLine(result4);
            //changed by its reference so number1 is changed by method
            Console.WriteLine(number1); //30

            int number3;// not need for value. set at least once inside method.
            int number4 = 100;

            var result5 = Add6(out number3, number4);
            Console.WriteLine(result5);
            //changed by its reference so number1 is changed by method
            Console.WriteLine(number3); //30

            Console.WriteLine(Multiply(2, 4)); // 8

            Console.WriteLine(Multiply(2, 4, 5)); // 40

            Console.WriteLine(Add7(1, 2, 3, 4, 5, 6)); // 21

            Console.WriteLine(Add8(1, 2, 3, 4, 5, 6)); // 20

           // Console.WriteLine(Add9(1, 2, 3, 4, 5, 6)); // error

            Console.ReadLine();

        }
        //Method without parameters.
        static void Add()
        {
            Console.WriteLine("Added!!!!");
        }
        //Method with parameters.
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        //Method with default parameters. Default param must not be the first.
        static int Add3(int x, int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add4(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        //Method with "ref" parameter.
        static int Add5(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //Method with "out" parameter. (Same with "ref").
        static int Add6(out int number3, int number4)
        {
            number3 = 30; // must be set at once.
            return number3 + number4;
        }

        //Method for multiply
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //Method for multiply with multiple paramaters. Method Overloading (Same method name)
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //Add method with "params" keyword. Same logic with method overloading (for more parameters).
        static int Add7(params int[] numbers)
        {
            return numbers.Sum();
        }

        //Add method with "params" keyword. Same logic with method overloading (for more parameters). Value "1" is not counted
        static int Add8(int number, params int[] numbers)
        {
            return numbers.Sum();
        }

        //error: last parameter has to be params
        //Add method with "params" keyword. Same logic with method overloading (for more parameters). Value "1" and "6" are not counted
        //static int Add9(int number, params int[] numbers, int number2)
        //{
        //    return numbers.Sum();
        //}
    }
}
