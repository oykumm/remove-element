/* Given an array nums and a value val, remove all instances of that value in-place and return the new length.*/
using System;

namespace repeatingcharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;

            Console.WriteLine("Enter string");
            string str = Console.ReadLine();

            j = LengthOfLongestSubstring(str);
            Console.WriteLine("Output " + j);
        }
        public static int LengthOfLongestSubstring(string s)
        {

            var longest = 0;


            if (s == null || s == "") return longest;
            var n = s.Length;
            if (n == 1) return 1;
            var left = 0;
            var charAndIndex = new int[256];
            for (int i = 0; i < charAndIndex.Length; i++)
            {
                charAndIndex[i] = -1;
            }
            charAndIndex[s[0]] = 0;
            for (var right = 1; right < n; right++)
            {
                var rightChar = s[right];
                if (charAndIndex[rightChar] != -1)
                {
                    if (charAndIndex[rightChar] >= left)
                    {
                        left = charAndIndex[rightChar] + 1;
                    }
                }
                charAndIndex[rightChar] = right;
                longest = Math.Max(longest, right - left + 1);
            }
            return longest;
        }
    }
}

