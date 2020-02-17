using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Strings
{
    class BeautifulBinaryString
    {
        public static int beautifulBinaryString(string b)
        {
            int count = 0;
            while(true)
            {
                int index = b.IndexOf("010");
                if(index > -1)
                {
                    b = b.Substring( index + 3 ); // because the substring length is 3.
                    count++;
                } else
                {
                    break;
                }
            }
            return count;
        }
    }
}
