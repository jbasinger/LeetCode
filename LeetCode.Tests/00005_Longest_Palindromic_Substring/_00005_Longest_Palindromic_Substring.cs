using LeetCode._00005_Longest_Palindromic_Substring;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00005_Longest_Palindromic_Substring
{
    public class Tests
    {

        private readonly Solution _sut = new();

        [Test]
        public void ShouldReturnEmptyString()
        {
            _sut.LongestPalindrome("").ShouldBe("");
        }

        [Test]
        public void ShouldReturnSingleCharacter()
        {
            _sut.LongestPalindrome("a").ShouldBe("a");
        }

        [Test]
        public void PalindromeInTheBeginning()
        {
            _sut.LongestPalindrome("babad").ShouldBe("bab");
        }

        [Test]
        public void PalindromeInTheMiddle()
        {
            _sut.LongestPalindrome("cbbd").ShouldBe("bb");
        }

        [Test]
        public void PalindromeAtTheEnd()
        {
            _sut.LongestPalindrome("asedad").ShouldBe("dad");
        }

        [Test]
        public void PalindromeIsTheWholeString()
        {
            _sut.LongestPalindrome("racecar").ShouldBe("racecar");
        }

        [Test]
        public void SmallPalindromeInBiggerPalindrome()
        {
            _sut.LongestPalindrome("awefryracecaryrfxyz").ShouldBe("fryracecaryrf");
        }
        
        [Test]
        public void NoPalindromes()
        {
            _sut.LongestPalindrome("ab").ShouldBe("a");
        }
    }
}