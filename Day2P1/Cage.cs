using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P1
{
    internal class Cage<T> where T : Animal
    {

        public List<T> animals = new List<T>();
        public  void Arrive(T t)
        {
            if (t.Age > 8)
                throw new InvalidAgeException("Invalid Age !");

            else 
            {
                animals.Add(t);
                Console.WriteLine($"new animal added successfully");
            }
        }




    }
}
