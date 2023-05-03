using LeetCode_Solves.Problems;
using LeetCode_Solves.Problems.InterviewProblems;
using System;
using System.Collections.Generic;

namespace LeetCode_Solves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 2, 3 };
            Console.WriteLine(new LogestIncreasingSubsequence().LengthOfLIS(nums));
        }
    }
}
