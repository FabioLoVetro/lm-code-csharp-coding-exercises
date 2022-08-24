using System;
namespace Exercises
{
    public class Exercise003
    {
        // all flavours
        public string[] IceCreamFlavours = 
            { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        // position of the flavour. if the flavour is not present, return -1
        public int IceCreamCode(string iceCreamFlavour)
        {
            int code = -1;
            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i] == iceCreamFlavour)
                {
                    code = i;
                }
            }
            return code;
        }
    }
}
