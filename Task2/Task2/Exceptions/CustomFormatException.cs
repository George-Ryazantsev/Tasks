using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Exceptions
{
    internal class CustomFormatException : Exception
    {
        public string NumberPosition { get; }

        public CustomFormatException(string message, string numberPosition, Exception innerException)
            : base(message, innerException)
        {
            NumberPosition = numberPosition;
        }
    }
}
