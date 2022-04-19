using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solves.Problems.Arrays
{
    /*
     * Problem link - https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/
     */
    public class HeightCheckerClass
    {
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
    }
}
