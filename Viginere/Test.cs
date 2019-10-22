using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util = Utils.Utils;
namespace Viginere
{
    class Test
    {
        public static void Main()
        {
            Vigenere vigenere = new Vigenere(10);
            string[] tests =
            {
                "ana are mere",
                "AnA aRe MeRe",
                "The brown fox jumped over the fence.",
                "zxcvbnmasdfghjklqwertyuiop"
            };
            Util.TestCriptare(vigenere, tests);
         
        }
    }
}
