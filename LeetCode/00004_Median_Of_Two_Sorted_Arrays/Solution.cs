using System;
using System.Linq;

namespace LeetCode._00004_Median_Of_Two_Sorted_Arrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            if (nums1.Length == 0 && nums2.Length == 0)
                return 0;
            
            if (nums1.Length == 0)
                return MedianOfArray(nums2);
            
            if (nums2.Length == 0)
                return MedianOfArray(nums1);
            
            var totalLength = nums1.Length + nums2.Length;
            var arrLength = totalLength / 2+1;

            var buf = new int[arrLength];
            var Ai = 0;
            var Bi = 0;
            for (int i = 0; i < arrLength; i++)
            {
                if (Ai == nums1.Length)
                {
                    buf[i] = nums2[Bi++];
                    continue;
                }

                if (Bi == nums2.Length)
                {
                    buf[i] = nums1[Ai++];
                    continue;
                }
                    
                
                if (nums1[Ai] < nums2[Bi])
                    buf[i] = nums1[Ai++];
                else
                    buf[i] = nums2[Bi++];
                
            }

            if (totalLength % 2 == 0)
            {
                return (buf[arrLength - 1] + buf[arrLength - 2]) / 2d;
            }
            return buf[arrLength - 1];

        }

        public static double MedianOfArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            
            if (nums.Length == 1)
                return nums[0];
            
            if (nums.Length % 2 == 0)
            {
                return ((double) (nums[nums.Length / 2] + nums[(nums.Length / 2) - 1])) / 2;
            }
            
            return nums[nums.Length/2];
        }
        
    }
}