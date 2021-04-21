using System;
using LeetCode._00009_Palindrome_Number;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00009_Palindrome_Number
{
    public class _00009_Palindrome_Number
    {
        private Solution _sut = new();

        [Test]
        public void ShouldHandleNegativeNumbers()
        {
            _sut.IsPalindrome(-101).ShouldBeFalse();
            _sut.IsPalindrome(-10).ShouldBeFalse();
            _sut.IsPalindrome(-999).ShouldBeFalse();
            _sut.IsPalindrome(int.MinValue).ShouldBeFalse();
        }

        [Test]
        public void ShouldHandlePositiveNumbers()
        {
            _sut.IsPalindrome(101).ShouldBeTrue();
            _sut.IsPalindrome(123).ShouldBeFalse();
            
            _sut.IsPalindrome(10).ShouldBeFalse();
            
            _sut.IsPalindrome(1).ShouldBeTrue();
            _sut.IsPalindrome(123454321).ShouldBeTrue();
            _sut.IsPalindrome(1233321).ShouldBeTrue();
            _sut.IsPalindrome(123445321).ShouldBeFalse();
            
            _sut.IsPalindrome(int.MaxValue).ShouldBeFalse();
            
        }
    }
}