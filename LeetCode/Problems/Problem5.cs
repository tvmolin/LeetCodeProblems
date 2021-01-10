using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //Given a string s, return the longest palindromic substring in s.
    //"babad", "bab"
    public class Problem5
    {
        public static string LongestPalindromicSubstring(string inputString)
        {
            if (inputString.Length == 1)
            {
                return inputString;
            }

            string currentLongest = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                for (int x = inputString.Length; x > i; x--)
                {
                    string stringToTest = inputString.Substring(i, x - i);
                    string reversedString = Reverse(stringToTest);
                    if ((stringToTest == reversedString) && stringToTest.Length > currentLongest.Length)
                    {
                        currentLongest = stringToTest;
                    }
                }
            }

            return currentLongest;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
