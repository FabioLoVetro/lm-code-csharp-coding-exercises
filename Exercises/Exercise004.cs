using System;
namespace Exercises
{
    /// <summary>
    /// Class <c>Exercise004</c> contains exercise004.
    /// </summary>
    public class Exercise004
    {   
        /// <summary>
        /// Method <c>AddGigaSecond</c> returns
        /// a DateTime as a sum of dateTime passed as parameter and a gigasecond.
        /// <param name = dateTime> the dateTime parameter. </param>
        /// <return> a DateTime as a result of the sum. </return>
        /// </summary>
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            //A gigasecond is 10^9 (1,000,000,000) seconds.
            return dateTime.AddSeconds(1000000000);
        }
    }
}
