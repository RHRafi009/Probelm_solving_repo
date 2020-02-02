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
            //call method here
            //5 4 10
            //4 2 4 6 1
            //2 1 8 5
            //Console.WriteLine(GameofTwoStacks.twoStacks(10, new int[] { 4, 2, 4, 6, 1 }, new int[] { 2, 1, 8, 5 }));
            Console.WriteLine(MarsExploration.marsExploration("SOSSOSSOS"));
            watch.Stop();
            Console.WriteLine("Time needed: " + watch.Elapsed);
            //to make output console visible
            Console.ReadKey();  
        }
    }
}
