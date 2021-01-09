using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTests
{
    public class Problem4Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, new int[] { 1 }, 1)]
        [InlineData(new int[] { 2 }, new int[] { }, 2)]
        [InlineData(new int[] { 5, 9, 7, 8, 10 }, new int[] { 11, 25, 32}, 9.5)]
        public void ShouldReturnMedianOfTwoArrays(int[] nums1, int[] nums2, double expectedValue)
        {
            Assert.Equal(expectedValue, Problem4.FindMedianSortedArrays(nums1, nums2));
        }
    }
}
