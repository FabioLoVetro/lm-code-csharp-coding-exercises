using System;
namespace Exercises
{
    /// <summary>
    /// Class <c>Exercise003</c> contains exercise003.
    /// </summary>
    public class Exercise003
    {
        ///<value>Property <c>IceCreamFlavours</c> all the flavours.</value>
        public string[] IceCreamFlavours = 
            { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        /// <summary>
        /// Method <c>IceCreamCode</c> return the position of the flavour. if the flavour is not present, return -1.
        /// <param name = iceCreamFlavour> the string flavours. </param>
        /// <return>
        /// a int, the position of the flavour in the tubs.
        /// -1, if the flavour is not present
        /// </return>
        /// </summary>
        public int IceCreamCode(string iceCreamFlavour)
        {
            int code = -1;
            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i] == iceCreamFlavour) code = i;
            }
            return code;
        }
    }
}
