using System;
namespace Exercises
{
    public class Exercise004
    {   
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            //A gigasecond is 10^9 (1,000,000,000) seconds.
            return dateTime.AddSeconds(1000000000);
        }
    }
}
