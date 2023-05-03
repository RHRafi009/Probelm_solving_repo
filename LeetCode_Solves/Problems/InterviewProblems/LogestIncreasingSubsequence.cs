using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solves.Problems.InterviewProblems
{
    public class LogestIncreasingSubsequence
    {
        private Dictionary<int, int> lis = new();
        private int[] numbers;

        public int LengthOfLIS(int[] nums)
        {
            numbers = nums;
            for (int i = 0; i<numbers.Length; i++)
            {
                LisForIndex(i);
            }

            int ans = 0;

            foreach (var l in lis)
            {
                if(l.Value > ans) ans = l.Value;
            }

            return ans;
        }

        private int LisForIndex(int i)
        {
            if (lis.ContainsKey(i))
            {
                return lis.GetValueOrDefault(i);
            }

            int res = 0;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] > numbers[i])
                {
                    int subResult = LisForIndex(j);
                    if (subResult > res)
                    {
                        res = subResult;
                    }
                }
            }

            lis.Add(i, res + 1);
            return lis[i];
        }
    }
}
