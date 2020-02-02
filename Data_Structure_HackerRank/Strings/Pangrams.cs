using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Strings
{
    class Pangrams
    {
        public static string pangrams(string s)
        {
            List<char> cArr = new List<char>();
            int len = s.Length;
            s = s.ToLower();
            for(int i=0; i<len; i++)
            {
                if (!cArr.Contains(s[i]) && s[i] != ' ')
                    cArr.Add(s[i]);
            }
            if (cArr.Count == 26)
                return "pangram";
            else
                return "not pangram";
        }
    }
}
