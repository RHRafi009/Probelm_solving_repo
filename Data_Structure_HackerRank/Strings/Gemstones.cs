using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Strings
{
    class Gemstones
    {
        static string letterArr = "abcdefghijklmnopqrstuvwxyz";


        public static int gemstones(string[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                string val = arr[i];
                for(int j=0; j<letterArr.Length; j++)
                {
                    char c = letterArr[j];
                    if (val.IndexOf((char)letterArr[j]) < 0)
                    {
                        letterArr = letterArr.Remove(j, 1);
                        j--;
                    }
                       
                }
            }

            return letterArr.Length;
        }
    }
}
