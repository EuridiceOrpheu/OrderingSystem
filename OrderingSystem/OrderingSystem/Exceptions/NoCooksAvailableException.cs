using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystem.Exceptions
{
    class NoCooksAvailableException : Exception
    {
        public NoCooksAvailableException(string message)
            : base(message)
        {
        }

        public NoCooksAvailableException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

