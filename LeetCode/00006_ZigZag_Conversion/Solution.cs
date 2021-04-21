using System;
using System.Text;

namespace LeetCode._00006_ZigZag_Conversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {

            if (numRows <= 1 || numRows >= s.Length)
            {
                return s;
            }

            var goingDown = true;
            var rowStrings = new StringBuilder[numRows];
            var bounceIndex = 0;

            for (var i = 0; i < numRows; i++)
            {
                rowStrings[i] = new StringBuilder();
            }
            
            foreach (var ch in s)
            {

                if (bounceIndex == 0)
                {
                    goingDown = true;
                }
            
                rowStrings[bounceIndex].Append(ch);
                if (goingDown)
                {
                    if (bounceIndex == numRows-1)
                    {
                        goingDown = false;
                        bounceIndex--;
                    }
                    else
                    {
                        bounceIndex++;
                    }
                }
                else
                {
                    
                    bounceIndex--;
                    if (bounceIndex == 0)
                    {
                        goingDown = true;
                    }
                }
            }

            var finalOutput = new StringBuilder();
            foreach (var sb in rowStrings)
            {
                finalOutput.Append(sb);
            }

            return finalOutput.ToString();

        }
    }
}