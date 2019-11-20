using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Stacks
{
    class MaximumElement
    {

        private static void ProcessInput (string val, out int x, out int y)
        {
            string[] arr = val.Split(' ');
            if(arr.Length==2)
            {
                x = int.Parse(arr[0]);
                y = int.Parse(arr[1]);
            }else
            {
                x = int.Parse(arr[0]);
                y = -1;
            }
        }

        private static int Max(Stack<int> st)
        {
            int max = -1;
            foreach(int i in st)
            {
                if (i > max)
                    max = i;
            }

            return max;
        }

        public static void MaxElement()
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();
            String input;
            int max = -1;
            for(int i=0; i<N; i++)
            {
                input = Console.ReadLine();
                ProcessInput(input, out int x, out int y);
                if(x == 1)
                {
                    st.Push(y);
                    if (y > max)
                        max = y;
                }else if(x == 2)
                {
                    st.Pop();
                    max = Max(st);
                }else if(x == 3)
                {
                    Console.WriteLine(max);
                }
            }
        }

    }
}
