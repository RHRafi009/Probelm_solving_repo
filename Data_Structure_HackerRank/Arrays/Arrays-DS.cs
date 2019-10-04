using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Arrays
{
    class Arrays_DS
    {
        //the reverseArray function
        public static int[] reverseArray(int[] a)
        {
            int[] arr = new int[a.Length];
            int i = 0, j = a.Length - 1;
            for (; i < a.Length; i++, j--)
                arr[i] = a[j];
            return arr;
        }
    }
}
