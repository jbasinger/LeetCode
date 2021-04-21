using System;
using LeetCode._00008_String_to_Integer;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00008_String_to_Integer
{
    public class _00008_String_to_Integer
    {
        private Solution _sut = new Solution();
        
        [Test]
        public void ShouldConvertString()
        {
            _sut.MyAtoi("42").ShouldBe(42);
            _sut.MyAtoi("12345").ShouldBe(12345);
        }

        [Test]
        public void ShouldConvertNegativeNumbers()
        {
            _sut.MyAtoi("-42").ShouldBe(-42);
            _sut.MyAtoi("-12345").ShouldBe(-12345);
        }

        [Test]
        public void ShouldConvertPositiveNumbers()
        {
            _sut.MyAtoi("+42").ShouldBe(42);
        }

        [Test]
        public void ShouldIgnoreLeadingWhitespace()
        {
            _sut.MyAtoi("              +42").ShouldBe(42);
            _sut.MyAtoi("              -42").ShouldBe(-42);
            _sut.MyAtoi("               42").ShouldBe(42);
            _sut.MyAtoi("              +42              ").ShouldBe(42);
            _sut.MyAtoi("              -42              ").ShouldBe(-42);
            _sut.MyAtoi("               42              ").ShouldBe(42);
        }

        [Test]
        public void ShouldClampOutside32Bit()
        {
            _sut.MyAtoi("9999999999").ShouldBe(int.MaxValue);
            _sut.MyAtoi("-9999999999").ShouldBe(int.MinValue);
        }

        [Test]
        public void ShouldStopOnNonDigitCharacters()
        {
            _sut.MyAtoi("42abcr123").ShouldBe(42);
            _sut.MyAtoi("-42abcr123").ShouldBe(-42);
            _sut.MyAtoi("+sdfsdf42abcr123").ShouldBe(0);
            _sut.MyAtoi("-sdfsdf42abcr123").ShouldBe(0);
        }

        [Test]
        public void ShouldReturn0OnGibberish()
        {
            _sut.MyAtoi("aiuwfbe").ShouldBe(0);
            _sut.MyAtoi("+aiuwfbe").ShouldBe(0);
            _sut.MyAtoi("-aiuwfbe").ShouldBe(0);
            
        }

        [Test]
        public void ShouldHandleEmptyString()
        {
            _sut.MyAtoi("").ShouldBe(0);
        }
        
    }
}