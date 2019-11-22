using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Stacks
{
    class BalancedBrackets
    {
        static char[] open = { '(', '{', '[' };
        static char[] close = { ')', '}', ']' };
        static int indx;
        static Boolean Open(char c)
        {
            for(int i=0; i<3; i++)
            {
                if (c == open[i])
                {
                    indx = i;
                    return true;
                }
                    
            }
            return false;
        }

        static Boolean Close(char c)
        {
            for (int i = 0; i < 3; i++)
            {
                if (c == close[i])
                {
                    indx = i;
                    return true;
                }
                    
            }
            return false;
        }

        public static string isBalanced(string s)
        {
            Stack<int> st = new Stack<int>();
            for(int i=0; i<s.Length; i++)
            {
                if(Open(s[i]))
                {
                    st.Push(indx);
                }else if(Close(s[i]))
                {
                    if (st.Count < 1)
                        return "NO";
                    if (indx == st.Peek())
                        st.Pop();
                    else
                        return "NO";
                }
            }

            if (st.Count < 1)
                return "YES";
            else
                return "NO";
        }
    }
}
