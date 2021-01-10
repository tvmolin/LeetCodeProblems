using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTests
{
    public class Problem5Tests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("ac", "a")]
         public void ShouldReturnLongestPalindrome(string s, string expectedOutput)
        {
            Assert.Equal(expectedOutput, Problem5.LongestPalindromicSubstring(s));
        }
    }
}
