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
            if (word == null)
            {
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
            string restOfTheString = word.Substring(1, word.Length - 1);
            // return a string equal to word with the first charatter uppercase
            return firstChar.ToUpper() + restOfTheString;
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            // to obtein the initial of the name
            string iniN = firstName.Substring(0, 1);
            // to obtein the initial of the name
            string iniL = lastName.Substring(0, 1);
            //return a string with the initials
            return iniN + "." + iniL;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.

            // to manage the exception price negative
            if (originalPrice < 0) throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            // to manage the exception vat negative
            if (vatRate < 0) throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            // compute the vat
            double vat = originalPrice * vatRate / 100;
            // return the price + vat
            return Math.Round((originalPrice + vat), 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();

            if (sentence == null) return null;

            // to obtain the array of the charatters from the string
            char[] array = sentence.ToCharArray();
            // to revers the array
            Array.Reverse(array);
            // return a new string from the array reversed
            return new string(array);
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            int count = 0;
            // if the list is null return 0
            if (users == null) { return 0; }
            // if the list is empty return 0
            if (users.Capacity == 0) { return 0; }
            // iteration the list and count how many Linux OP user
            foreach (User u in users)
            {
                if (u.Type == "Linux")
                {
                    count++;
                }

            }
            // return the number of the user for Linux
            return count;
        }

    }
}
