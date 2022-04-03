using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Arrays
{
    /*
     * Problem link - https://www.hackerrank.com/challenges/dynamic-array/problem?isFullScreen=false
     */
    public class DynamicArray
    {
        /*
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. 2D_INTEGER_ARRAY queries
        */

        /*
         * This is getting runtime error. why? 
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<int> ans = new List<int>();
            List<List<int>> arr = new List<List<int>>();
            int lastAnswer = 0, idx;

            for (int i = 0; i < n; i++)
                arr.Add(new List<int>());

            foreach (List<int> query in queries)
            {
                switch(query[0])
                {
                    case 1:
                        idx = ((query[1] ^ lastAnswer) % n);
                        arr[idx].Add(query[2]);
                        break;
                    case 2:
                        idx = ((query[1] ^ lastAnswer) % n);
                        int lineIdx = (query[2] % arr[idx].Count);
                        lastAnswer = arr[idx][lineIdx];
                        ans.Add(lastAnswer);
                        break;
                    default:
                        /*This path should be impossible.*/
                        break;
                }
            }
            return ans;
        }
    }
}
