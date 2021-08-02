using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            if (num > short.MaxValue)
            {
                throw new OverflowException("Value too large to Convert to short");
            }
            return (short)num;
        }

        public static long FloatToLong(float num)
        {
            return Convert.ToInt64(num);
        }
    }
}
