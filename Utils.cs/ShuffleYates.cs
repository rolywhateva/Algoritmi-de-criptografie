using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public  class ShuffleYates<T>
    {
       
        public   T[] Shuffle(T[] array, int seed=0)
        {
            Random rnd = new Random(seed);
            for(int i=0;i<array.Length-1;i++)
            {
                int j = rnd.Next(i, array.Length);
                Utils.Swap(ref array[i],ref  array[j]);

            }
            return array;
        }
        /*
        public  ICollection<T> Shuffle(ICollection<T> enumerable, int seed =0)
        {
            ICollection<T> result = Shuffle(enumerable.ToArray<T>(), seed);
            return result;
            
        }
        */
       
    }
}
