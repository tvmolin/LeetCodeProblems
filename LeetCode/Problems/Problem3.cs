using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class Problem3
    {
        //Given a string s, 
        //find the length of the longest substring without repeating characters.

        public static int lengthOfLongestSubstring(string inputString)
        {
            if (inputString.Length == 0)
            {
                return 0;
            }

            int longestSoFar = 1;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i == inputString.Length - 1)
                {
                    break;
                }

                string substring = "" + inputString[i];
                for (int x = i + 1; x < inputString.Length; x++)
                {
                    if (substring.Contains(inputString[x]))
                    {
                        break;
                    }
                    substring += inputString[x];
                    longestSoFar = longestSoFar < substring.Length ? substring.Length : longestSoFar;
                }
            }

            return longestSoFar;
        }

    }
}
