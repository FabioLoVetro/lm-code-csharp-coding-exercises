using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            bool result = true;
            string s = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                if(!input.ToLower().Contains(s.Substring(i,1))) result = false;
            }
            return result;
        }
    }
}
