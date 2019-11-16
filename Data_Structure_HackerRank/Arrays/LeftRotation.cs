using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Arrays
{
    class LeftRotation
    {

        // This will fail test case 6 and 9 due to large number of values 

        public static int[] LeftRotate(int[] arr, int d)
        {
            int[] temp = new int[d];
            for(int i=0; i<d; i++)
            {
                temp[i] = arr[i];
            }

            for(int i=0, j=d; i<d && j<arr.Length; i++, j++)
            {
                arr[i] = arr[j];
            }
            for (int i = (arr.Length - d), j=0; i < arr.Length && j<temp.Length; i++, j++)
            {
                arr[i] = temp[j];
            }
            return arr;
        }
    }
}
