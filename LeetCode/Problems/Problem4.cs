using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //Given two sorted arrays nums1 and nums2 of size m and n respectively, 
    //return the median of the two sorted arrays.

    //Follow up: The overall run time complexity should be O(log (m+n)).
    public class Problem4
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = nums1.Concat(nums2).ToArray();
            if(mergedArray.Length == 1)
            {
                return mergedArray[0];
            }
            return FindMedian(mergedArray);
        }

        private static double FindMedian(int[] nums)
        {
            Array.Sort(nums);

            int arrayLength = nums.Length;

            //If array has odd amount of items
            if (arrayLength % 2 == 1)
            {
                int medianIndex = (arrayLength / 2);
                return nums[medianIndex];
            } else
            {
                int medianIndex1 = (arrayLength / 2) - 1;
                int medianIndex2 = medianIndex1 + 1;
                return (double) (nums[medianIndex1] + nums[medianIndex2]) / 2;
            }
        }
    }
}
