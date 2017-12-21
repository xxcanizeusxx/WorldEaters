using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEaters.Utils
{
    class WordlEatersExceptions : System.Exception
    {
        public WordlEatersExceptions()
        {

        }
        public WordlEatersExceptions(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : Exception
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }

    class OnPathException : Exception
    {
        public OnPathException()
        {

        }

        public OnPathException(string message) : base(message)
        {

        }
    }
}

