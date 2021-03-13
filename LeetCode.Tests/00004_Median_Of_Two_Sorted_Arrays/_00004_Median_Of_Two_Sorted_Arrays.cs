using LeetCode._00004_Median_Of_Two_Sorted_Arrays;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00004_Median_Of_Two_Sorted_Arrays
{
    public class Tests
    {
        private Solution _sut = new Solution();

        [Test]
        public void ShouldReturnMedian()
        {
            var nums1 = new int[]{1,3};
            var nums2 = new int[]{2};
            var appended = new int[] {1, 2, 3};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }

        [Test]
        public void ShouldReturnAverageMedian()
        {
            var nums1 = new int[]{1,2};
            var nums2 = new int[]{3,4};
            var appended = new int[] {1, 2, 3, 4};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }

        [Test]
        public void ShouldAccountForZeroes()
        {
            var nums1 = new int[]{0,0};
            var nums2 = new int[]{0,0};
            var appended = new int[] {0,0,0,0};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }

        [Test]
        public void ShouldWorkWithEmptyArrays()
        {
            var nums1 = new int[]{};
            var nums2 = new int[]{1};
            var appended = new int[] {1};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[]{2};
            nums2 = new int[]{};
            appended = new int[] {2};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[]{};
            nums2 = new int[]{};
            appended = new int[] {};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[]{1,2,3,4,5};
            nums2 = new int[]{};
            appended = new int[] {1, 2, 3, 4, 5};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[]{1,2,3,4};
            nums2 = new int[]{};
            appended = new int[] {1,2,3,4};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }

        [Test]
        public void ShouldWorkWithSingleElementArrays()
        {
            var nums1 = new int[]{1};
            var nums2 = new int[]{2};
            var appended = new int[] {1,2};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }
        
        /*
         * A [--|--]
         * B            [--|--]
         */
        [Test]
        public void AllOfAIsLessThanB()
        {
            var nums1 = new int[]{1,2,3,4};
            var nums2 = new int[]{10,11,12,13,14};
            var appended = new int[] {1, 2, 3, 4, 10, 11, 12, 13, 14};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }
        
        /*
         * A             [--|--]
         * B [---|--]
         */
        [Test]
        public void AllOfAIsBiggerThanB()
        {
            var nums1 = new int[]{10,11,12,13,14};
            var nums2 = new int[]{1,2,3,4};
            var appended = new int[] {1, 2, 3, 4, 10, 11, 12, 13, 14};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }
        
        /*
         * A   [--|--]
         * B [----|---]
         */
        [Test]
        public void AandBMediansAreEqual()
        {
            var nums1 = new int[]{1,1,2,3,4};
            var nums2 = new int[]{0,1,2,3,4};
            var appended = new int[] {0, 1, 1, 1, 2, 2, 3, 3, 4, 4};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }
        
        /*
         * A [--|---]
         * B  [---|--]
         */
        [Test]
        public void AisInBbutLessThanBMedian()
        {
            var nums1 = new int[]{-1,0,1,2,3,4};
            var nums2 = new int[]{0,1,2,3,4};
            var appended = new int[] {-1,0,0,1,1,2,2,3,3,4,4};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }
        
        /*
         * A      [----|----]
         * B  [-----|----]
         */
        [Test]
        public void AisInBbutGreaterThanBMedian()
        {
            var nums1 = new int[]{1,2,3,4,5,6};
            var nums2 = new int[]{0,1,2,3,4};
            var appended = new int[] {0,1,1,2,2,3,3,4,4,5,6};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }

        [Test]
        public void AllMixedIn()
        {
            var nums1 = new int[] {0, 2, 4, 6, 8};
            var nums2 = new int[] {1, 3, 5, 7, 9};
            //[0,1,2,3,4,5,6,7,8,9]
            var appended = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[] {2, 4, 6, 8};
            nums2 = new int[] {1, 3, 5, 7};
            //[1,2,3,4,5,6,7,8]
            appended = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
        }

        [Test]
        public void WeirdOnesIThoughtWereNeat()
        {
            var nums1 = new int[]{1,1,1,100,100,100};
            var nums2 = new int[]{50,50,50};
            //[1,1,1,50,50,50,100,100,100]
            var appended = new int[] {1,1,1,50,50,50,100,100,100};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);

            nums1 = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            nums2 = new int[] {1, 2, 3, 4, 5};
            appended = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
        }

        [Test]
        public void SubmissionTestCases()
        {
            var nums1 = new int[] {1};
            var nums2 = new int[] {2, 3, 4};
            var appended = new int[] {1,2,3,4};
            var val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);     
            
            nums1 = new int[] {2,3,4};
            nums2 = new int[] {1};
            appended = new int[] {1,2,3,4};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[] {4};
            nums2 = new int[] {1,2,3};
            appended = new int[] {1,2,3,4};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[] {1,2,3};
            nums2 = new int[] {4};
            appended = new int[] {1,2,3,4};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
            nums1 = new int[] {2};
            nums2 = new int[] {1,3,4};
            appended = new int[] {1,2,3,4};
            val = Solution.MedianOfArray(appended);
            _sut.FindMedianSortedArrays(nums1, nums2).ShouldBe(val);
            
        }
        
    }
}