using System.Collections.Generic;
using System.Linq;

namespace Data_Structure_HackerRank.Arrays
{
    class LeftRotation
    {
        // Problem link - https://www.hackerrank.com/challenges/array-left-rotation/problem?isFullScreen=false

        public static List<int> LeftRotate(int d, List<int> arr)
        {
            int arrLength = arr.Count;

            List<int> resArr = new List<int>(), leftArr = new List<int>(), restOfArr = new List<int>();            

            for(int i = 0; i<arrLength; i++)
            {
                if (i < d)
                {
                    leftArr.Add(arr[i]);
                }
                else
                {
                    restOfArr.Add(arr[i]);
                }
            }

            resArr.AddRange(restOfArr);
            resArr.AddRange(leftArr);
            
            return resArr;
        }
    }
}
