using LeetCode._00003_Longest_Substring_Without_Repeating_Characters;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00003_Longest_Substring_Without_Repeating_Characters
{
    public class Tests
    {
        /*
         * Edge cases
         * - All the same character
         * - the long string is at the end
         * - the long string is first
         * - the long string is in the middle
         * - the whole string is the substring
         * - the string is empty
         * - the string is one character
         */
        
        private Solution _sut = new Solution();
        
        [Test]
        public void ShouldReturnOneIfAllTheSame()
        {
            var str = "bbbbb";
            var res = _sut.LengthOfLongestSubstring(str);
            res.ShouldBe(1);
        }

        [Test]
        public void ShouldReturnZeroIfEmpty()
        {
            var res = _sut.LengthOfLongestSubstring("");
            res.ShouldBe(0);
        }
        
        [Test]
        public void ShouldReturnLongStringAtTheEnd()
        {
            var str = "rywtrwqewtytyuiop";
            var res = _sut.LengthOfLongestSubstring(str);
            res.ShouldBe(6);
        }

        [Test]
        public void ShouldReturnLongStringAtBeginning()
        {
            var str = "poiuytytweqwrtwyr";
            var res = _sut.LengthOfLongestSubstring(str);
            res.ShouldBe(6);
        }
        
        [Test]
        public void ShouldReturnLongStringInTheMiddle()
        {
            var str = "qweqrrplikfudjggtyr";
            var res = _sut.LengthOfLongestSubstring(str);
            res.ShouldBe(10);
        }
        
        [Test]
        public void ShouldReturnTheWholeThing()
        {
            var str = "qwertyuiop";
            var res = _sut.LengthOfLongestSubstring(str);
            res.ShouldBe(str.Length);
        }

        [Test]
        public void ShouldReturnOneIfOneCharacter()
        {
            var str = "o";
            var res = _sut.LengthOfLongestSubstring(str);
            res.ShouldBe(str.Length);
        }
        
    }
}