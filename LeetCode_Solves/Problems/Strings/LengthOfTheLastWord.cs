using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solves.Problems.Strings
{
    public class LengthOfTheLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            string[] arr = s.Split(' ');
            return arr[arr.Length - 1].Length;
        }

        public int LengthOfLastWord2(string s)
        {
            s = s.TrimEnd();
            int length = s.Length;
            int count = 0;
            for(int i = length - 1; i>=0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
