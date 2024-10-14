using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Exceptions
{
    internal class CustomOverflowException : Exception
    {
        public CustomOverflowException(string message) : base(message) { }
    }
}
