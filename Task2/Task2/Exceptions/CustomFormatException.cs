using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Exceptions
{
    internal class CustomFormatException : Exception
    {
        public CustomFormatException(string message) : base(message) { }
    }
}
