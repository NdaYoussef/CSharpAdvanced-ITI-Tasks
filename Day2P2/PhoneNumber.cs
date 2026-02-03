using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P2
{
    internal class PhoneNumber
    {

         Dictionary<string, int> phoneNumbers = new Dictionary<string, int>();

        public void AddPhoneNo(string name, int No)
        {
            phoneNumbers[name] = No;
            Console.WriteLine("phone number added successfully");
        }
       
        public int GetPhoneNo(string name)
        {
            if (phoneNumbers.TryGetValue(name, out int number))
                return number;
    
                throw new InvalidNumberException("number not found!");

        }
    }
}
