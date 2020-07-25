using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortedMultiMap
{
   public  class SortedMultiMap< K, V > 
    {
        
         private List<int>  hash_list = new  List<int>();
         private List<Pair> elements = new List<Pair>();

        private struct Pair
        {
             public K Key;
             public List<V> Value;

        }

        public void Add(K a, V b)
        {

            var hash = a.GetHashCode();
             if (!hash_list.Contains(hash))
             {
                hash_list.Add(hash);
                Pair pair;
                pair.Key = a;
                List<V> list = new List<V>();
                pair.Value = list;
                pair.Value.Add(b);
                elements.Add(pair);
             }
            else
            {
                foreach (var i in  elements)
                {
                    if (i.Key.GetHashCode() == hash)
                    {
                        if (i.Value.Contains(b))
                        {
                            Console.WriteLine(" this pair {0},{1} already exists",i.Key,b);
                            break;
                        }
                        i.Value.Add(b);
                        i.Value.Sort();
                        break;

                    }
                }

            }
            
        }

   public List<V> Get(K key)
        {
            List<V> return_value=new List<V>();
            var hash = key.GetHashCode();

            
                if (!hash_list.Contains(hash))
                {

                return null;

                }
                else
                {
                    foreach (var i in elements)
                    {
                        if (i.Key.GetHashCode() == hash)
                        {
                           
                            return_value = i.Value;
                            break;
                        }

                    }

                }
                return return_value;
            




        }

        public void Remove (K key,V value)
        {
            var hash = key.GetHashCode();

            try
            {
                if (!hash_list.Contains(hash))
                {
                    throw new SortedMapDosntContainThisKeyOrValue();

                }
                else
                {
                    int count = 0;
                    foreach (var i in elements)
                    {
                       
                        if (i.Key.GetHashCode() == hash)
                        {
                            if (i.Value.Count == 1)
                            {
                                elements.Remove(i);
                                hash_list.Remove(hash);
                                break;
                            }
                            else
                            {
                                i.Value.Remove(value);
                                break;
                            }

                        }
                        count++;
                    }
                    if(count==elements.Count)
                    throw new SortedMapDosntContainThisKeyOrValue();
                }
            }

            catch (SortedMapDosntContainThisKeyOrValue e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveAll(K key)
        {
            var hash = key.GetHashCode();
            try
            {

                if (!hash_list.Contains(hash))
                {
                    throw new SortedMapDosntContainThisKeyOrValue();

                }
                else
                {
                    foreach (var i in elements)
                    {
                        if (i.Key.GetHashCode() == hash)
                        {
                            elements.Remove(i);
                            hash_list.Remove(hash);
                            break;

                        }
                    }

                }
            }
            catch (SortedMapDosntContainThisKeyOrValue e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public  IEnumerator GetEnumerator()
        {
         
            foreach (var i in elements)
            {

                foreach (var j in i.Value)
                {
                    yield return new KeyValuePair<K, V>(i.Key, j);
                }

            }

        }

    }
}
