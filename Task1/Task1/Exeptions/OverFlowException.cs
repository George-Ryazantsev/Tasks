using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exeptions
{
    internal class OverFlowException : Exception
    {
        public OverFlowException()
        {
            Console.WriteLine(" Error: число превышает допустимый диапазон значений!");
            Environment.Exit(1);
        }
    }
}
