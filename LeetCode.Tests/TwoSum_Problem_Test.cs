using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests
{
    public class Tests
    {
        [Test]
        public void ShouldReturnSumOfTarget()
        {
            var res = TwoSum_Problem.TwoSum(new int[] {2, 7, 11, 15}, 9);
            res[0].ShouldBe(0);
            res[1].ShouldBe(1);
            
            res = TwoSum_Problem.TwoSum(new int[] {3,2,4}, 6);
            res[0].ShouldBe(1);
            res[1].ShouldBe(2);
            
            res = TwoSum_Problem.TwoSum(new int[] {3,3}, 6);
            res[0].ShouldBe(0);
            res[1].ShouldBe(1);
            
            res = TwoSum_Problem.TwoSum(new int[] {3,2,3}, 6);
            res[0].ShouldBe(0);
            res[1].ShouldBe(2);
            
            res = TwoSum_Problem.TwoSum(new int[] {0,2,3,8,5,22,11,6}, 9);
            res[0].ShouldBe(2);
            res[1].ShouldBe(7);
            
        }
    }
}