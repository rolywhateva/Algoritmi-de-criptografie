using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Util = Utils.Utils;
using ShuffleYates = Utils.ShuffleYates<string>;
namespace PoliAlfabetic
{
    class Program
    {
       static string inFilePath = "../../textClar.txt";
       static  string outFilePath = "../../textCriptat.txt";
       static  string permutationFile = "../../permutation.txt";

        static void WritePermutation()
        {
            StreamWriter writer = new StreamWriter(permutationFile);
            ShuffleYates generator = new ShuffleYates();
            string[] perm = generator.Shuffle(Util.GetAlphabet(), Util.Seed);
            writer.WriteLine(string.Join(" ", perm));
            writer.Close();
        }
        
        static void Main(string[] args)
        {
            //WritePermutation()
            //get  permutation from  permutation.txt
            HashSet<string> set =   Util.GetWordsFromFile(permutationFile, new char[] { ' ' });
            PoliAlfabetic poliAlfabetic = new PoliAlfabetic(set);

            StreamReader reader = new StreamReader(inFilePath);
            StreamWriter writer = new StreamWriter(outFilePath);
            string line;
            while((line=reader.ReadLine())!=null)
            {
                writer.WriteLine(poliAlfabetic.Criptare(line));
            }
            reader.Close();
            writer.Close();
          






        }
    }
}
