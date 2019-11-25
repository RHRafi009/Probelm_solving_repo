using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Stacks
{
    class EqualStacks
    {

        static int s1Height, s2Height, s3Height;

        public static int GetHeight(Stack<int> s)
        {
            int height = 0;
            if (s.Count == 0)
                return height;
            else
            {
                foreach(int i in s)
                {
                    height += i;
                }
                return height;
            }
        }

        public static int MostHighestStack(Stack<int> s1, Stack<int> s2, Stack<int> s3)
        {
            int i = 0;
            if (s1Height == s2Height && s2Height == s3Height)
                return i;
            else
            {
                if (s1Height >= s2Height && s1Height >= s3Height)
                    i = 1;
                else if (s2Height >= s1Height && s2Height >= s3Height)
                    i = 2;
                else
                    i = 3;
            }
            return i;
        }


        public static void InitStack(int[] arr, out Stack<int> s)
        {
            s = new Stack<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
                s.Push(arr[i]);
        }

        public static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            Stack<int> s1, s2, s3;
            InitStack(h1, out s1);
            InitStack(h2, out s2);
            InitStack(h3, out s3);
            s1Height = GetHeight(s1);
            s2Height = GetHeight(s2);
            s3Height = GetHeight(s3);
            bool flag = false;
            while(!flag)
            {
                int height = MostHighestStack(s1, s2, s3);
                if(height == 0)
                {
                    flag = true;
                }else if(height == 1)
                {
                    s1Height -= s1.Peek();
                    s1.Pop();
                }else if(height == 2)
                {
                    s2Height -= s2.Peek();
                    s2.Pop();
                }else
                {
                    s3Height -= s3.Peek();
                    s3.Pop();
                }
            }
            return s1Height;
        }

    }
}
