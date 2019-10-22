using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util = Utils.Utils;
using ShuffleYates = Utils.ShuffleYates<string>;
namespace PoliAlfabetic
{
    class PoliAlfabetic : AlgoritmiIstorici.AlgoritmCriptare
    {
        string[]  key;
        public string[] Key
        {
            get
            {
                return key;
            }

        }
        private Dictionary<string, string> dictionar;
        private Dictionary<string, string> reverseDictionary;
        public PoliAlfabetic(HashSet<string> set)
        {
            this.key = set.ToArray<string>();
            if (key.Length != 26)
                throw new Exception("Insuficient");
            buildDictionary();
            printDictionary(dictionar);
            Console.WriteLine("===================");
            printDictionary(reverseDictionary);

        }
        public  void printDictionary(Dictionary<string,string> dictionar)
        {
            foreach(string key in dictionar.Keys)
            {
                Console.WriteLine("{0}->{1}", key, dictionar[key]);
            }
        }
        private void buildDictionary()
        {
            dictionar = new Dictionary<string, string>();
            reverseDictionary = new Dictionary<string, string>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                dictionar.Add(i.ToString(), key[i-'a']);
                dictionar.Add(i.ToString().ToUpper() ,key[i-'a'].ToUpper());
                reverseDictionary.Add(key[i - 'a'], i.ToString());
                reverseDictionary.Add(key[i - 'a'].ToUpper(), i.ToString().ToUpper());
            }
        }
        public PoliAlfabetic()
        {
            key = new ShuffleYates().Shuffle(Util.GetAlphabet());
            buildDictionary();
           
            
        }
        public override string Criptare(string textClar)
        {
           
            string textCriptat = "";
            for (int i = 0; i < textClar.Length; i++)
                if (char.IsLetter(textClar[i]))
                    textCriptat += dictionar[textClar[i].ToString()];
                else
                    textCriptat += textClar[i];
            
            return textCriptat;

        }

        public override string Decriptare(string textCriptat)
        {
            string textClar = "";
            for (int i = 0; i < textCriptat.Length; i++)
                if (!char.IsLetter(textCriptat[i]))
                    textClar += textCriptat[i];
                 else 
                    textClar += reverseDictionary[textCriptat[i].ToString()];


                
            return textClar;
        }
        public static string CriptoAnaliza(string textCriptat,Letter[] sampleFrequency,Letter[] cryptedFrequency)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            int length = Math.Min(sampleFrequency.Length, cryptedFrequency.Length);
             for (int i=0;i<length;i++)
            {
                char c = char.ToLower(sampleFrequency[i].Character);
                if(c>='a'&&c<='z')
                {
                    map.Add(char.ToLower(cryptedFrequency[i].Character), sampleFrequency[i].Character);
                    map.Add(char.ToUpper(cryptedFrequency[i].Character), char.ToUpper(sampleFrequency[i].Character));
                }
            }
            string textClar = "";

            for (int i = 0; i < textCriptat.Length; i++)
                if (char.IsLetter(textCriptat[i]))
                {
                    textClar += map[textCriptat[i]];

                }
                else
                    textClar += textCriptat[i];
            return textClar;
            
       
        }
    }
}
