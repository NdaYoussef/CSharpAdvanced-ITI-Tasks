using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P1
{
    internal class Cage<T> where T : Animal
    {
        public void Arrive(T t)
        {
            if (t.Age > 8)
                throw new Exception("Invalid Age !");
        }




    }
}
