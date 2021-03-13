using LeetCode._00002_Add_Two_Numbers;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00002_Add_Two_Numbers
{
    public class Tests
    {
        [Test]
        public void ShouldBuildListNodeFromIntArray()
        {
            var sut = new Solution();
            
            var input = new[] {2, 4, 3};
            var node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));
            
            input = new[] {5, 6, 4};
            node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));

            input = new[] {9, 9, 9};
            node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));

            input = new[] {0, 0, 0, 1};
            node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));

            input = new[] {7, 0, 8};
            node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));

            input = new[] {1};
            node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));

            input = new[] {0};
            node = sut.BuildList(input);
            input.ShouldBe(sut.Output(node));
            
        }

        [Test]
        public void ShouldAddNumbers()
        {
            var sut = new Solution();

            var l1 = sut.BuildList(new[] {2, 4, 3});
            var l2 = sut.BuildList(new[] {5,6,4});
            var res = sut.AddTwoNumbers(l1, l2);
            sut.Output(res).ShouldBe(new[] {7, 0, 8});
            
            l1 = sut.BuildList(new[] {0});
            l2 = sut.BuildList(new[] {0});
            res = sut.AddTwoNumbers(l1, l2);
            sut.Output(res).ShouldBe(new[] {0});
            
            l1 = sut.BuildList(new[] {9,9,9});
            l2 = sut.BuildList(new[] {9});
            res = sut.AddTwoNumbers(l1, l2);
            sut.Output(res).ShouldBe(new[] {8,0,0,1});
            
            l1 = sut.BuildList(new[] {9,9,9,9,9,9,9});
            l2 = sut.BuildList(new[] {9,9,9,9});
            res = sut.AddTwoNumbers(l1, l2);
            sut.Output(res).ShouldBe(new[] {8,9,9,9,0,0,0,1});
            
        }
        
    }
}