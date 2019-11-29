using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_HackerRank.Stacks
{
    class SimpleTextEditor
    {
        static string s = "";
        static Stack<string> history = new Stack<string>();


        static void Append(string val)
        {
            s += val;
            history.Push(s);
        }

        static void Delete(int index)
        {
            if(s.Length-index >= 0)
                s = s.Remove(s.Length - index);
            history.Push(s);
        }

        static void Print(int index)
        {
            if (s.Length > 0 && index <= s.Length)
                Console.WriteLine(s[index - 1]);
            else
                Console.WriteLine();
        }

        static void Undo()
        {
            history.Pop();
            if (history.Count > 0)
                s = history.Peek();
            else
                s = "";
        }

        public static void TextEditor()
        {
            int a = Int32.Parse(Console.ReadLine());
            int action;
            string val, input;
            string[] inputArr;
            for (int i = 0; i < a; i++)
            {
                val = "";
                input = Console.ReadLine().ToString();
                inputArr = input.Split(' ');
                action = int.Parse(inputArr[0]);
                if (action == 1)
                {
                    val = inputArr[1];
                    Append(val);
                }
                else if (action == 2)
                {
                    Delete(int.Parse(inputArr[1]));
                }
                else if (action == 3)
                {
                    Print(int.Parse(inputArr[1]));
                }
                else if (action == 4)
                {
                    if(history.Count > 0)
                        Undo();
                }
            }
        }
    }
}
