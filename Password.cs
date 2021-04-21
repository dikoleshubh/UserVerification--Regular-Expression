using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class Password
    {
        static string password = "^(?=.*[a - z])(?=.*[A - Z])(?=.*)(?=.*[^a - zA - Z]).{8}$"; ////Ideal Pasword  Condition
        Regex regexEmail = new Regex(password);
        public void passwordvarification(string passwordID)
        {
            if (regexEmail.IsMatch(passwordID))//// Checking condition
            {
                Console.WriteLine("Password Is  Valid");
            }
            else
            {
                Console.WriteLine("Password Is  Invalid");
            }
        }
    }
}
