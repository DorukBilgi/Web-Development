using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccessModifiers;// C/C++ dilinde .h file eklemek gibi düþünülebilir.

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //AccessModifiers projesinde tanýmlý olan "Course" classýný baþka bir proje olan AccessModifiersDemo' dan kullanmak istersek.
            //AccessModifiersDemo -> References -> Add References -> AccessModifiers
            //using AccessModifiers;
            Course course = new Course();

        }
    }
}
