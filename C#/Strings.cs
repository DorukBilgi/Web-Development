using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Doruk Bilgi";
            var result1 = sentence.Length;
            Console.WriteLine(result1);//22 (space is also counted)
            
            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("i");
            Console.WriteLine(result3);
            
            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("name");//3
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf(" ");//2
            Console.WriteLine(result6);

            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            var result8 = sentence.Insert(0,"Hello, ");
            Console.WriteLine(result8);

            var result9 = sentence.Substring(3);//after 3rd character
            Console.WriteLine(result9);

            var result10 = sentence.ToLower();
            Console.WriteLine(result10);
            
            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ","-");
            Console.WriteLine(result12);

            var result13 = sentence.Remove(2);//remove after second index
            Console.WriteLine(result13);

            var result14 = sentence.Remove(2,5);//remove five character after second index
            Console.WriteLine(result14);

            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "??stanbul";
            string result = city + city2;

            Console.WriteLine(String.Format("{0}{1}", city, city2));
            Console.WriteLine(result);
            
        }
    }
}
