using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day5P2
{
    public static class Test
    {

        public static string checkEmail (this string email)
        {
            if (email.Contains('@'))
                return email;

            return "email not valid!";
        }

        public static string checkEmailRegEx (this string email)
       {
            bool isValid = Regex.IsMatch(email, "^[a-zA-Z0-9]+@[a-z]+\\.[a-z]+$");

            if (isValid)
                return email;

            return "Not matched!";

        }
    }
}
