namespace LeetCode._00009_Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            
            if (x < 10)
                return true;

            var rev = 0;
            var orig = x;
            while (x != 0)
            {
                rev = (rev * 10) + (x % 10);
                x /= 10;
            }

            return rev == orig;
        }
    }
}