using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Arrays
{
    class SparseArrays
    {
        public static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] arr = new int[queries.Length];
            int count = 0;
            for (int i = 0; i < queries.Length; i++)
            { 
                foreach(string item in strings)
                {
                    if (item == queries[i])
                        count++;
                }
                arr[i] = count;
                count = 0;
            }
            return arr;
        }
    }
}
