using System;
namespace Exercises
{
    public class Exercise003
    {
        // all flavours
        public string[] IceCreamFlavours = 
            { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        // position of the flavour
        public int IceCreamCode(string iceCreamFlavour)
        {
            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i] == iceCreamFlavour)
                {
                    return i;
                }
            }
        }
    }
}
