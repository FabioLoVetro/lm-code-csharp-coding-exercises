using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    /// <summary>
    /// Class <c>Exercise001</c> contains exercise001.
    /// </summary>
    public class Exercise001
    {
        /// <summary>
        /// Method <c>CapitalizeWord</c> returns the string word with the first charatter uppercase.
        /// <param name = word> the string word. </param>
        /// <return> the string word with the first charatter uppercase. </return>
        /// </summary>
        public string CapitalizeWord(string word)
        {
            // in case the parameter is null, the method return null
            if (word == null) return null;

            // in case the parameter is "", the method return ""
            if (word == "") return "";

            // in case the parameter is " ", the method return " "
            if (word == " ") return " ";

            // get the first charatter of the string
            string firstChar = word.Substring(0, 1);
            // get the string without the first charatter
            string restOfTheString = word.Substring(1, word.Length - 1);
            // return a string equal to word with the first charatter uppercase
            return firstChar.ToUpper() + restOfTheString;
        }

        /// <summary>
        /// Method <c>GenerateInitials</c> returns the initials.
        /// <param name = firstName> the name. </param>
        /// <param name = lastName> the surname. </param>
        /// <return> the string with the initials. </return>
        /// </summary>
        public string GenerateInitials(string firstName, string lastName)
        {
            // to obtein the initial of the name
            string iniN = firstName.Substring(0, 1);
            // to obtein the initial of the name
            string iniL = lastName.Substring(0, 1);
            //return a string with the initials
            return iniN + "." + iniL;
        }

        /// <summary>
        /// Method <c>AddVat</c> add vat to a price.
        /// <param name = originalPrice> the price. </param>
        /// <param name = vatRate> the vat. </param>
        /// <return> the double price + vat. </return>
        /// </summary>
        public double AddVat(double originalPrice, double vatRate)
        {
            // to manage the exception price negative
            if (originalPrice < 0) throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            // to manage the exception vat negative
            if (vatRate < 0) throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            // compute the vat
            double vat = originalPrice * vatRate / 100;
            // return the price + vat
            return Math.Round((originalPrice + vat), 2);
        }

        /// <summary>
        /// Method <c>Reverse</c> reverse a string.
        /// <param name = sentence> the string to reverse. </param>
        /// <return> the string reversed. </return>
        /// </summary>
        public string Reverse(string sentence)
        {
            if (sentence == null) return null;

            // to obtain the array of the charatters from the string
            char[] array = sentence.ToCharArray();
            // to revers the array
            Array.Reverse(array);
            // return a new string from the array reversed
            return new string(array);
        }

        /// <summary>
        /// Method <c>CountLinuxUsers</c> counts users that use Linux.
        /// <param name = users> the list of the users. </param>
        /// <return> int, the number of the users. </return>
        /// </summary>
        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            // if the list is null return 0
            if (users == null) { return 0; }
            // if the list is empty return 0
            if (users.Capacity == 0) { return 0; }
            // iteration the list and count how many Linux OP user
            foreach (User u in users)
            {
                if (u.Type == "Linux") count++;
            }
            // return the number of the user for Linux
            return count;
        }

    }
}
