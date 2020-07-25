using System;
using System.Collections.Generic;

namespace SortedMultiMap
{
    class Program
    {
        static void Main()
        {
            
            SortedMultiMap<int, int> x = new SortedMultiMap<int, int>();
            //Add pair
            x.Add(3, 5);
            x.Add(3, 1);
            x.Add(4, 5);
            x.Add(3, 7);
            x.Add(3, 1);
            x.Add(3, 8);
            x.Add(3, 9);
            x.Add(4, 1);
            x.Add(4, 2);


            foreach (var j in x)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
            //get values by key 
            var i=x.Get(3);
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();

            //remove value by key
            x.Remove(3, 5);
            x.Remove(3, 1);

            foreach (var j in x)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();

            //remove pair 
          
            x.RemoveAll(4);

            foreach (var j in x)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();


            //union two maps
            SortedMultiMap<int, int> y = new SortedMultiMap<int, int>();
            y.Add(5, 5);
            y.Add(6, 5);
            y.Add(3, 1);
             SortedMultiMap<int, int> z= x.Union(y);
            foreach (var item in z)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //intersect two maps

            x.Add(7, 8);
            y.Add(7, 8);
            x.Add(3, 1);
            SortedMultiMap<int, int> w = x.Intersect(y);
            foreach (var item in w)
            {
                Console.WriteLine(item);
            }

        }
    }
}
