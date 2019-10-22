using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Util = Utils.Utils;
namespace PoliAlfabetic
{
    public class CriptoAnaliza
    {
        static string samplePath = "../../testsample.txt";
        static string cryptedPath = "../../textcriptat.txt";
       
        static void PrintFrequency(Letter[] letters, int limit =4)
        {
            int nr = 0;
            foreach(Letter letter in  letters)
            {
                Console.Write("{0}-->{1}  ", letter.Character, letter.Frequency);
                nr++;
                if (nr >= limit)
                {
                    nr = 0;
                    Console.WriteLine();

                }
            }
        }
        static void Main()
        {

            HashSet<string> sampleWords = Util.GetWordsFromFile(samplePath, new char[] {'-','.','\"','\'','?','!', ' ',','});
            HashSet<string> criptedWords = Util.GetWordsFromFile(cryptedPath, new char[] { ' ' });
    

            Dictionary<char, int> sampleFrequency = Util.GetFrequencyFromWords(sampleWords);
            Dictionary<char, int> criptedFrequency = Util.GetFrequencyFromWords(criptedWords);

            Letter[] sampleLetters = Letter.FromDictionary(sampleFrequency);
            Letter[] criptedLetters = Letter.FromDictionary(criptedFrequency);
            Array.Sort(sampleLetters, new LetterFrequencyComparer());
            Array.Sort(criptedLetters, new LetterFrequencyComparer());

            Console.WriteLine("Frequency of  letters in the sample text:");
            PrintFrequency(sampleLetters, 3);
            Console.WriteLine();
            Console.WriteLine("Frequency of  letters in the  crypted text  :");
            PrintFrequency(criptedLetters, 3);

            StreamReader reader = new StreamReader(cryptedPath);
            string line;

            while ((line= reader.ReadLine())!=null)
            {
             //   Console.WriteLine("Rezultate pentru :{0}", line);
                string rez = PoliAlfabetic.CriptoAnaliza(line, sampleLetters, criptedLetters);
                Console.WriteLine(rez);

            }


        }
    }
}
