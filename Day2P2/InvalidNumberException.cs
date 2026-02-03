using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P2
{
    internal class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message):base(message)
        { }
    }
}
