using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode._00003_Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0)
                return 0;

            if (s.Length == 1)
                return 1;
            
            var maxLength = 1;
            var curLength = 0;
            var chars= new Dictionary<char, bool>(); 

            for (var i = 0; i < s.Length; i++)
            {
                chars.Clear();
                var firstChar = s[i];
                chars[firstChar] = true;
                curLength = 1;
                
                for (var j = i+1; j < s.Length; j++)
                {
                    var currentChar = s[j];
                    if (chars.ContainsKey(currentChar))
                    {
                        if (j == s.Length - 1)
                        {
                            return maxLength;
                        }
                        break;
                    }
                    
                    chars[currentChar] = true;
                    curLength++;
                    if (maxLength <= curLength)
                        maxLength = curLength;
                    
                    if (j == s.Length - 1)
                    {
                        return maxLength;
                    }
                    
                }
            }
            
            return maxLength;
        }
    }
}