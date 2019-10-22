using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util = Utils.Utils;
namespace PoliAlfabetic
{
    public class Test
    {
        static void Main()
        {
            PoliAlfabetic encoder = new PoliAlfabetic();
      
            string[] tests = {
                "aabbcc",
                "aCBa dE",
                "aAbBcC",
                "Ana are mere si 2 prune."
            };
            Util.TestCriptare(encoder, tests);



        }
    }
}
