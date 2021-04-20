using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class Name
    {
        static string Name = "^[A-Z]{1}[a-z]{2,}$";
        Regex regexName = new Regex(Name);

        public void firstname ( string firstname)
        {
            if(regexName.IsMatch(firstname))
            {
                Console.WriteLine("First Name Is  Valid");
            }
            else
            {
                Console.WriteLine("First Name Is  Invalid");
            }
        }
        public void Lastname(string Lastname)
        {
            if (regexName.IsMatch(Lastname))
            {
                Console.WriteLine("Last Name Is  Valid");
            }
            else
            {
                Console.WriteLine("Last Name Is  Invalid");
            }
        }

    }

}
