using System;

namespace LimitOfTypes
{
    public class LimitOfByte
    {
        public byte GetMaximum => byte.MaxValue;
        public byte GetMinimum => byte.MinValue;

       
        public byte GetUnSignedNumber(string input)
        {
            if (!(input.Length == 8))
                throw new ArgumentOutOfRangeException();

            foreach (var item in input)
            {
                if (!(item == '1' || item == '0'))
                    throw new ArgumentException();
            }

            if (input == null)
                throw new ArgumentNullException();


            byte result = 0;
            int index = 7;
            foreach (var item in input)
            {
                int convertTo = Convert.ToInt32(new string(item,1));
                result += (byte)(convertTo * Math.Pow(2, index));

                index --;
            }
            return result;
        }
    }
}
