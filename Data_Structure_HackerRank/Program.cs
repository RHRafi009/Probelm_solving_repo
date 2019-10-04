using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structure_HackerRank.Arrays;

namespace Data_Structure_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Arrays_DS.reverseArray(new int[] { 2,3,4,5});
            foreach (int i in arr)
                Console.Write(i + " ");


            //to make output console visible
            Console.ReadKey();  
        }
    }
}
