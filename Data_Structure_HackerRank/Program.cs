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
            _ = LeftRotation.LeftRotate(2, new List<int> { 1, 2, 3, 4, 5 });
            watch.Stop();
            Console.WriteLine("Time needed: " + watch.Elapsed);
            //to make output console visible
            Console.ReadKey();  
        }
    }
}
