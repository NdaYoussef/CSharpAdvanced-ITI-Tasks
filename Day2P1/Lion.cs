using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P1
{
    internal class Lion :Animal
    {
        public string Name { get; set; }
        public Lion(string name)
        {
            Name = name;
        }
        public void Roar()
        {
            Console.WriteLine("Lion roars");
        }
    }
}
