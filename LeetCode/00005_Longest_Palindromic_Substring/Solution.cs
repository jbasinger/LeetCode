using System;
using System.Linq;

namespace LeetCode._00005_Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0 || s.Length==1)
                return s;

            var longestPali = s[0].ToString();

            for (var i = 0; i < s.Length; i++)
            {
                //Walk backward until you find the same character then start looking for a palindrome
                for (var j = s.Length - 1; j >= i; j--)
                {
                    if (s[i] == s[j]) //Potential Palindrome
                    {
                        
                        var len = j - i+1;
                        
                        //If the length is smaller than our current one, why bother!
                        if (len <= longestPali.Length)
                            continue;
                        
                        var isPalindrome = true;
                        var tempPali = new char[len];

                        for (int front = i, back = j, first = 0, last = len-1; front <= back; front++, back--, first++, last--)
                        {
                            if (s[front] != s[back])
                            {
                                isPalindrome = false;
                                break;
                            }

                            tempPali[first] = s[front];
                            tempPali[last] = s[back];
                        }

                        var newPali = new string(tempPali);
                        if (isPalindrome && newPali.Length > longestPali.Length)
                        {
                            longestPali = newPali;
                        }
                        
                    }
                }
                
            }
            
            return longestPali;
        }
    }
}