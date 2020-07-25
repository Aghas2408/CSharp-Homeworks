using System;
using System.Collections.Generic;
using System.Text;

namespace SortedMultiMap
{
      class SortedMapDosntContainThisKeyOrValue: Exception
       {

        public SortedMapDosntContainThisKeyOrValue()
        {
            Console.WriteLine("Invalid Key or Value");

        }

       }
}
