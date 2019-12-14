using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Stacks
{
    class GameofTwoStacks
    {

        // apperantly I have used the wrogn sets of logic here

        public static int twoStacks(int x, int[] a, int[] b)
        {
            int move = 0, sum = 0, indexA = 0, indexB = 0;
            while (sum <= x)
            {
                if (indexA >= a.Length || indexB >= b.Length)
                    break;
                if(a[indexA] <= b[indexB])
                {
                    if (x < sum + a[indexA])
                        break;
                    move++;
                    sum += a[indexA];
                    indexA++;
                }else
                {
                    if (x < sum + b[indexB])
                        break;
                    move++;
                    sum += b[indexB];
                    indexB++;
                }
            }
            return move;
        }
    }
}
