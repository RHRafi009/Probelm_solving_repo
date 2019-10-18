using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Arrays
{
    class _2DArray_DS
    {
        // Complete the hourglassSum function below.
        public static int hourglassSum(int[][] arr)
        {
            int[] hourGlusIndexI = { 0, 0, 0, 1, 2, 2, 2 };
            int[] hourGlusIndexJ = { 0, 1, 2, 1, 0, 1, 2 };
            List<int> sumArr = new List<int>();
            
            for (int i = 0; i<4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = arr[hourGlusIndexI[0]][ hourGlusIndexJ[0]] + arr[hourGlusIndexI[1]][ hourGlusIndexJ[1]] + arr[hourGlusIndexI[2]][ hourGlusIndexJ[2]] + arr[hourGlusIndexI[3]][ hourGlusIndexJ[3]] + arr[hourGlusIndexI[4]][ hourGlusIndexJ[4]] + arr[hourGlusIndexI[5]][ hourGlusIndexJ[5]] + arr[hourGlusIndexI[6]][ hourGlusIndexJ[6]];
                  
                    sumArr.Add(sum);
                    for (int k = 0; k < 7; k++)
                        hourGlusIndexJ[k]++;
                }
                
                for (int k = 0; k < 7; k++)
                {
                    hourGlusIndexI[k]++;
                    hourGlusIndexJ[k] -= 4;
                }

            }
            sumArr.Sort();
            
            return sumArr[sumArr.Count - 1];
        }

       
    }
}
