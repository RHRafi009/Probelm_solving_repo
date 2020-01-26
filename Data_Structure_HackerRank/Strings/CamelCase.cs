using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Strings
{
    public class CamelCase
    {
        public static int camelcase(string s)
        {
            int count = 1, length = s.Length;
            for(int i = 0; i<length; i++)
            {
                if (!Char.IsLower(s[i]))
                    count++;
            }
            return count;
        }
    }
}
