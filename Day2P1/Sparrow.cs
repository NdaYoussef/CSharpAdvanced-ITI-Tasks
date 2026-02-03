using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P1
{
    internal class Sparrow : Animal
    {
        public string Name { get; set; }
        public Sparrow(string name)
        {
            Name = name;
        }
        public void Fly()
        {
            Console.WriteLine("sparrow flies");
        }
    }
}
