using System;
using System.Collections.Generic;

namespace SortedMultiMap
{
    class Program
    {
        static void Main()
        {
            
            SortedMultiMap<int, int> x = new SortedMultiMap<int, int>();
            x.Add(3, 5);
            x.Add(4, 5);
            x.Add(3, 7);
            x.Add(3, 1);
            var i=x.Get(3);
            //foreach (var j in x)
            //{
            //    Console.WriteLine(j);
            //}
            //foreach (var item in i)
            //{
            //    Console.WriteLine(item);
            //}
       
            
            SortedMultiMap<int, int> y = new SortedMultiMap<int, int>();
            y.Add(5, 5);
            y.Add(6, 5);
            y.Add(3, 7);
            y.Add(3, 1);

            SortedMultiMap<int, int> z= x.Union(y);
            foreach (var item in z)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            SortedMultiMap<int, int> w = x.Intersect(y);
            foreach (var item in w)
            {
                Console.WriteLine(item);
            }
          
        }
    }
}
