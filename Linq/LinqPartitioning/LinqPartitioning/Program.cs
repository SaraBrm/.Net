using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> data = new List<int>() { 5, 3, 6, 2, 4, 7, 8, 1 };

            var dataSkip = data.Skip(4);
            foreach (var item in dataSkip)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\n__________________SkipWhile__________________");
            var dataSkipWhile = data.SkipWhile(p => p < 8);
            foreach (var item in dataSkipWhile)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\n__________________Take__________________");
            var dataTake = data.Take(3);
            foreach (var item in dataTake)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("\n_________________TakeWhile________________");
            var dataTakeWhile = data.TakeWhile(p => p < 8);
            foreach (var item in dataTakeWhile)
            {
                Console.Write(item + ",");
            }


            // Equality
            Console.WriteLine("\n\n\n\n\n_________________SequenceEqual________________");

            IList<int> data2 = new List<int>() { 5, 3, 10 };
            IList<int> data3 = new List<int>() { 5, 6, 10 };

            var result = data2.SequenceEqual(data3);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
