using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTests
{
    public class Problem3Tests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        public void shouldFindLengthOfLongestSubstringWithoutRepeatingCharacters(string input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Problem3.lengthOfLongestSubstring(input));
        }
    }
}
