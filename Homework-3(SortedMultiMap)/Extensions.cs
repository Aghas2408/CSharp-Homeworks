using System;
using System.Collections.Generic;
using System.Text;

namespace SortedMultiMap
{

    static class Extensions

    {
        public static SortedMultiMap<K, V> Union<K,V>( this SortedMultiMap<K, V> dict1, SortedMultiMap<K, V> dict2)
        {
            SortedMultiMap<K, V> dict3 = new SortedMultiMap<K, V>();
            foreach (KeyValuePair<K, V> item in dict1)
            {
                        dict3.Add(item.Key, item.Value);
            }
            foreach (KeyValuePair<K, V> item in dict2)
            {
                dict3.Add(item.Key, item.Value);
            }
            return dict3;
        }

        public static SortedMultiMap<K, V> Intersect<K, V>( this SortedMultiMap<K, V> dict1, SortedMultiMap<K, V> dict2)
        {
            SortedMultiMap<K, V> dict3 = new SortedMultiMap<K, V>();
            foreach (KeyValuePair<K, V> item in dict1)
            {
                if (dict2.Get(item.Key) != null)
                {
                    foreach (KeyValuePair<K, V> item2 in dict2)
                    {
                        if (Equals(item.Key, item2.Key) & (Equals(item.Value, item2.Value)))
                        {
                            dict3.Add(item.Key, item.Value);
                            break;
                        }
                    }
                }
            }
            return dict3;
        }
    }
}
