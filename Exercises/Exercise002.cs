using System;
using Exercises.Models;

namespace Exercises
{
    /// <summary>
    /// Class <c>Exercise002</c> contains exercise002.
    /// </summary>
    public class Exercise002
    {
        /// <summary>
        /// Method <c>IsFromManchester</c> return true if the person is from manchester
        /// <param name = person> the person to check. </param>
        /// <return> a boolean to indicate if the person is from Manchester. </return>
        /// </summary>
        public bool IsFromManchester(Person person)
        {
            return (person != null && person.city == "Manchester");
        }
        /// <summary>
        /// Method <c>CanWatchFilm</c> returns
        /// true, if the person is equal or older of the ageLimit
        /// false, if it is not.
        /// <param name = person> the person to check. </param>
        /// <param name = ageLimit> the age limit. </param>
        /// <return> a boolean to indicate if the person can watch film. </return>
        /// </summary>
        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return (person != null && person.age >= ageLimit);
        }
    }
}
