using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solves.Problems
{
    /*
     * Problem Title - 1. Two Sum
     */
    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            List<int> result = new List<int>();

            for(int i=0; i<nums.Length; i++)
            {
                if (!result.Contains(i))
                {
                    for(int j = i+1; j<nums.Length; j++)
                    {
                        if (!result.Contains(j))
                        {
                            if (nums[i] + nums[j] == target)
                            {
                                result.Add(i);
                                result.Add(j);
                                break;
                            }
                        }
                    }
                }
                if (result.Count == 2)
                    break;
            }

            return result.ToArray();
        }

        /*
         * With O(n) approach
         */
        public int[] TwoSumMethod2(int[] nums, int target)
        {
            Dictionary<int, int> numsDic = new Dictionary<int, int>();

            int loopLength = nums.Length;

            for(int i=0; i<loopLength; i++)
            {
                int diff = target - nums[i];
                if(numsDic.ContainsKey(diff))
                    return new int[] { numsDic[diff], i };
                else
                {
                    if (!numsDic.ContainsKey(nums[1]))
                        numsDic.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
