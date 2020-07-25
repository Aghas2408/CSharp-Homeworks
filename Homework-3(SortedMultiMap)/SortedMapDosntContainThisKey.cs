using System;
using System.Collections.Generic;
using System.Text;

namespace SortedMultiMap
{
      class SortedMapDosntContainThisKey:Exception
       {

        public SortedMapDosntContainThisKey()
        {
            Console.WriteLine("Invalid Key");

        }

       }
}
