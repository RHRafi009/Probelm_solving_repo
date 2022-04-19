using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solves.Problems.Arrays
{
    public class ArrayProblems
    {
        /*
        * Problem link - https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/
        */
        public int HeightChecker(int[] heights)
        {
            var heightsList = heights.ToList();
            heightsList.Sort();
            int mismatchedIndices = 0;
            for(int i = 0; i<heights.Length; i++)
            {
                if (heights[i] != heightsList[i])
                    mismatchedIndices++;
            }
            return mismatchedIndices;
        }

        /*
        * Problem link - https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3231/
        */
        public int ThirdMax(int[] nums)
        {
            List<int> sorted = nums.ToList();
            sorted.Sort();
            int maxNumberRank = 1;
            int currentMax = 0;
            currentMax = sorted[sorted.Count - 1];
            int maxNumber = currentMax;
            for (int i = sorted.Count - 1; i>=0; i--)
            {
                if(maxNumberRank < 3)
                {
                    if (sorted[i] == currentMax)
                        continue;
                    else if(sorted[i] < currentMax)
                    {
                        currentMax = sorted[i];
                        maxNumberRank++;
                    }
                }
                else break;
            }
            return maxNumberRank == 3 ? currentMax : maxNumber;
        }
    }
}
