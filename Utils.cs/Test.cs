using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Test
    {
        public static void Main()
        {
             string[]  alphabet = Utils.GetAlphabet();
            ShuffleYates<string> shuffler = new ShuffleYates<string>();

            for (int i = 0; i < 100; i++)
            {
                int seed  = Guid.NewGuid().GetHashCode();
               string[] perm = shuffler.Shuffle(alphabet, seed);
                Console.WriteLine(string.Join("", perm));
            }
            Console.WriteLine("===========================");
            /*
            List<char> alphabet2 = Utils.GetAlphabet().ToList();
            for (int i = 0; i < 10; i++)
            {
                int hashCode = Guid.NewGuid().GetHashCode();
                List<char> perm = (List<char>)shuffler.Shuffle(alphabet2, hashCode);
                Console.WriteLine(string.Join("", perm));

            }
            */
            Console.ReadKey();
        }
    }
}
