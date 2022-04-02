using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structure_HackerRank.Arrays;
using Data_Structure_HackerRank.Stacks;
using Data_Structure_HackerRank.Strings;

namespace Data_Structure_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<List<int>> queries = new List<List<int>>() 
            {
                new List<int> { 1, 0, 5},
                new List<int> { 1, 1, 7},
                new List<int> { 1, 0, 3},
                new List<int> { 2, 1, 0},
                new List<int> { 2, 1, 1}
            };
            List<int> res = DynamicArray.dynamicArray(2, queries);
            watch.Stop();
            Console.WriteLine("Time needed: " + watch.Elapsed);
            //to make output console visible
            Console.ReadKey();  
        }
    }
}
