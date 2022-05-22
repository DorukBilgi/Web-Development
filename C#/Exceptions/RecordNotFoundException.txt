using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions //Add new class to this project. Our own exception class.
{
    public class RecordNotFoundException:Exception // Change this class to public. Inherit from Exception
    {
        public RecordNotFoundException(string message):base(message)// Type ctor then tab.
        {
            // Controlling message from ctor. Now you can give desired message from program.cs.
        }

    }
}
