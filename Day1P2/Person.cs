using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1P2
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}, {LastName}";

        public int Age { get; set; }

        private string _password;
        public string Password
        {
            set
            {
                _password = value;
            }
        }
    }
}
