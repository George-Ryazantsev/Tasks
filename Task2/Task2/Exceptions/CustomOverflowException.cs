using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Exceptions
{
    internal class CustomOverflowException : Exception
    {
        public string NumberPosition { get; }

        public CustomOverflowException(string message, string numberPosition, Exception innerException)
            : base(message, innerException)
        {
            NumberPosition = numberPosition;
        }
    }
}
