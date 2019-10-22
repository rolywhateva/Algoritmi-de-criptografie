using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmiIstorici;
using CriptType = AlgoritmiIstorici.AlgoritmCriptare;
using System.IO;
namespace Utils
{
    public static  class Utils
    {
       public static  void Swap<T>(ref T left, ref T right)
        {
            T aux = left;
            left = right;
            right = aux;
        }
        public static string[] GetAlphabet()
        {

            List<string> alphabet = new List<string>();
            for (char i = 'a'; i <= 'z'; i++)
                alphabet.Add(i.ToString());
            return alphabet.ToArray<string>();
        }
        public static int Seed
        {
            get
            {
                return Guid.NewGuid().GetHashCode();
            }
        }

        public static  char ShiftLetter(char c, int s)
        {
            s = s % 26;
            if (s < 0)
                s = 26 + s;
            char a;
            if (char.IsUpper(c))
                a = 'A';
            else
                a = 'a';

            return (char)(a + (c - a + s) % 26);
        }
         public static  string ShiftAllLetters(string textClar, int cheie)
        {
            string textCriptat = "";
            foreach (char c in textClar)
            {
                if (char.IsLetter(c))
                    textCriptat += Utils.ShiftLetter(c, cheie);
                else
                    textCriptat += c;
            }
            return textCriptat;
        }
        public static void TestCriptare(CriptType MetodaCript,string[] tests)
        {
            foreach(string test in tests)
            {
                
                string textcriptat = MetodaCript.Criptare(test);
                string textclar = MetodaCript.Decriptare(textcriptat);
                Console.WriteLine("{0}->{1}->{2}", test, textcriptat, textclar);
            }
        }
       public static HashSet<string> GetWordsFromFile(string path,char[] separatori)
        {
            StreamReader reader = new StreamReader(path);
            HashSet<string> set = new HashSet<string>();
            string line;
            while((line = reader.ReadLine())!=null)
            {
                string[] words = line.Trim().Split(separatori);
                foreach(string word in words)
                {
                    set.Add(word);
                }
            }
            return set;
            
                
            
        }
        public static Dictionary<char,int> GetFrequencyFromWords(HashSet<string> words)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach(string word in words)
            {
                for(int i=0;i<word.Length;i++)
                    if(char.IsLetter(word[i]))
                            try
                            {
                      
                                frequency[char.ToLower(word[i])]++;
                            }catch(Exception e)
                            {

                                
                                frequency.Add(char.ToLower(word[i]), 1);
                            }
            }
            return frequency;
        }
        public static char[,] AlphabetPerms
        {
            get
            {
              char[,]   perm = new char[26, 26];
                for (int i = 0; i < perm.GetLength(1); i++)
                    perm[0, i] = (char)('a' + i);
                for (int i = 1; i < perm.GetLength(0); i++)
                    for (int j = 0; j < perm.GetLength(1); j++)
                    {
                        perm[i, j] =Utils.ShiftLetter(perm[i - 1, j], 1);

                    }
                return perm;
            }
        }
        public static  bool IsUpperCase(char c)
        {
            return (c >= 'A' && c <= 'Z');
        }


    }
}
