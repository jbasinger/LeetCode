using System;

namespace LeetCode._00008_String_to_Integer
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            
            if (s.Length == 0)
                return 0;
            
            var mult = s[0] == '-' ? -1 : 1;

            try
            {
                checked
                {
                    if (s[0] == '-' || s[0] == '+')
                        s = s.Remove(0,1);
            
                    var num = 0;
            
                    foreach (int i in s)
                    {
                        if (i < 48 || i > 57)
                        {
                            return num * mult;
                        }

                        num *= 10;
                        num += i - 48;
                    }

                    return num * mult;
                }
            }
            catch (OverflowException)
            {
                return mult > 0 ? int.MaxValue : int.MinValue;
            }
           
        }
    }
}