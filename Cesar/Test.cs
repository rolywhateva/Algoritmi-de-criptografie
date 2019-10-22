using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Util = Utils.Utils;
using AlgoritmCriptare;
namespace Cesar
{
    public class Test
    {
        static void Main(string[] args)
        {
           Cesar cifru = new Cesar();
            string[] tests =
            {
                "aabbcc",
                "AaBbCc",
                "yzxYZX",
                "C",
                "The brown fox, tralalalalalalalalalalalalalalalalala"
            };
            Util.TestCriptare(cifru, tests);
            Util.TestCriptare(cifru, Util.GetAlphabet());
            /*
            foreach (string  test in Utils.Utils.GetAlphabet())
            {
                string clar = test.ToString();
                string criptat = cifru.Criptare(test.ToString());
                Console.WriteLine("{0}->{1}->{2}", clar, cifru.Criptare(test.ToString()), cifru.Decriptare(criptat));
            }
            foreach (string  test  in tests)
            {
                string clar = test.ToString();
                string criptat = cifru.Criptare(test.ToString());
                Console.WriteLine("{0}->{1}->{2}", clar, cifru.Criptare(test.ToString()), cifru.Decriptare(criptat));
            }
            */

        }
    }
}
