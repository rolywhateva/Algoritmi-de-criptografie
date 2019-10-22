using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Util = Utils.Utils;
namespace CifruN
{
   public  class CriptoAnaliza
    {
       static void Main()
        {

            HashSet<string> cuvinte = Util.GetWordsFromFile("../../dictionary.txt", 
           new char[] { ' ','.',',','!','?','-',':',';' });
          
            Console.WriteLine(string.Join("\n", cuvinte));
            StreamReader reader = new StreamReader("../../textcriptat.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("Rezultate pentru :\n" + line);
                
                for (int cheie = 1; cheie <= 25; cheie++)
                {
                    int nr;
                    string result = CifruN.CriptoAnaliza(line, cuvinte, cheie, out nr);
                    if (nr >= line.Split(new char[] { ' ' }).Length / 2)
                        Console.WriteLine(result);


                }
            }

          
        }
    }
}
