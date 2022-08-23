using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();

            // in case the parameter is null, the method return null
            if (word == null) {
                return null;
            }
            // in case the parameter is "", the method return ""
            if (word == "")
            {
                return "";
            }
            // in case the parameter is " ", the method return " "
            if (word == " ")
            {
                return " ";
            }
            // get the first charatter of the string
            string firstChar = word.Substring(0, 1);
            // get the string without the first charatter
            string restOfTheString = word.Substring(1, word.Length-1);
            // return a string equal to word with the first charatter uppercase
            return firstChar.ToUpper() + restOfTheString;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            // obtein the initial of the name
            string iniN = firstName.Substring(0, 1);
            // obtein the initial of the name
            string iniL = lastName.Substring(0, 1);
            //return a string with the initials
            return iniN +"."+ iniL;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }
    }
}
