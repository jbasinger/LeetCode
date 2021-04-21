using LeetCode._00007_Reverse_Integer;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00007_Reverse_Integer
{
    public class _00007_Reverse_Integer
    {
        private Solution _sut = new();
        
        [Test]
        public void ShouldReverseNumbers()
        {
            _sut.Reverse(123).ShouldBe(321);
            _sut.Reverse(12345).ShouldBe(54321);
        }

        [Test]
        public void ShouldReverseNegativeNumbers()
        {
            _sut.Reverse(-123).ShouldBe(-321);
        }

        [Test]
        public void ShouldReturnZeroOnZero()
        {
            _sut.Reverse(0).ShouldBe(0);
        }

        [Test]
        public void ShouldCountZeroAsZero()
        {
            _sut.Reverse(10001).ShouldBe(10001);
            _sut.Reverse(120).ShouldBe(21);
            _sut.Reverse(1200).ShouldBe(21);
            _sut.Reverse(12000).ShouldBe(21);
            _sut.Reverse(1201).ShouldBe(1021);
        }

        [Test]
        public void ShouldOnlyCount32BitNumbers()
        {
            _sut.Reverse(1534236469).ShouldBe(0);
            _sut.Reverse(-1534236469).ShouldBe(0);
        }
    }
}