using System;
namespace Exercises
{
    /// <summary>
    /// Class <c>Exercise005</c> contains exercise005.
    /// </summary>
    public class Exercise005
    {
        /// <summary>
        /// Method <c>IsPangram</c> returns
        /// true, if the paramiter string is a Pangram
        /// false, if it is not.
        /// <param name = input> the string to check. </param>
        /// <return> a boolean to indicate if the string is Pangram or not. </return>
        /// </summary>
        public bool IsPangram(string input)
        {
            bool result = true;
            string s = "abcdefghijklmnopqrstuvwxyz";
            //check if the charatters of the string s are conteined in the string
            //passed as parameter and set the variable result at false in case some charatter is missing
            for (int i = 0; i < s.Length; i++)
            {
                if(!input.ToLower().Contains(s.Substring(i,1))) result = false;
            }
            return result;
        }
    }
}
