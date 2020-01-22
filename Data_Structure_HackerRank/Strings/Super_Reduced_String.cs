using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Strings
{
    public class Super_Reduced_String
    {

        static bool checkDouble(string s)
        {
            for(int i=0; i<s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    return true;
            }
            return false;
        }
        // Complete the superReducedString function below.
        public static string superReducedString(string s)
        {
            while(checkDouble(s))
            {
                for(int i=0; i<s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                        s = s.Remove(i, 2);
                }
            }
            if (s == "")
                s = "Empty String";
            return s;
        }
    }
}
