using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exeptions
{
    internal class BadInputTypeException : Exception
    {
        public BadInputTypeException()
        {
            Console.WriteLine(" Error: неверный формат ввода!");
            Environment.Exit(1);
        }
    }
}
