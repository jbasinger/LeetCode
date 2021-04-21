using System;

namespace LeetCode._00007_Reverse_Integer
{
    public class Solution
    {
        public int Reverse(int x)
        {

            if (x == 0 || x > Int32.MaxValue || x < Int32.MinValue)
                return 0;
            
            try
            {
                var mult = x < 0 ? -1 : 1;
                var rev = 0;
            
                if (x < 0)
                    x *= -1;
            
                while (x != 0)
                {
                    rev = checked((rev * 10) + (x % 10)); //write about the overflow bit
                    x /= 10;
                }

                return rev * mult;
            }
            catch (OverflowException)
            {
                return 0;
            }
            
        }
    }
}