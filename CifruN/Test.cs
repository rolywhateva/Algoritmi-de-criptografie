using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Util   = Utils.Utils;
namespace CifruN
{
    public class Test
    {
        static void Main()
        {

            CifruN cifru = new CifruN();
            Console.WriteLine(cifru.Cheie);
            
            string[] tests = 
            {
                "aabbcc",
                "AaBbCc",
                "yzxYZX",
                "C",
                "The brown fox, tralalalalalalalalalalalalalalalalala"
            };
            Util.TestCriptare(cifru,tests);
            Console.WriteLine("==================");
            Util.TestCriptare(cifru, Util.GetAlphabet());
           
           
        }
    }
}
