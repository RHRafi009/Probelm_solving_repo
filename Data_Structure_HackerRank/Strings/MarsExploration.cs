using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Strings
{
    class MarsExploration
    {
        static string msg = "SOS";
        static int charFlag = 0;
        static char nextExpected()
        {
            char c = msg[charFlag];
            if (charFlag == 0 || charFlag == 1)
                charFlag++;
            else
                charFlag = 0;
            return c;
        }

        public static int marsExploration(string s)
        {
            int count = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] != nextExpected())
                    count++;
            }
            return count;
        }
    }
}
