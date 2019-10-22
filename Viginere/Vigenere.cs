using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util = Utils.Utils;
using ShuffleYates = Utils.ShuffleYates<string>;
namespace Viginere
{
    class Vigenere : AlgoritmiIstorici.AlgoritmCriptare
    {
        char[,] perm;
        string key;
        public string Key
        {
            get
            {
                return key;
            }
        }
        public Vigenere(string key)
        {
            this.key = key.ToLower();
            perm = Util.AlphabetPerms;
           
        }
        
        public Vigenere(int n)
        {
           string[]   keyPerm = new ShuffleYates().Shuffle(Util.GetAlphabet(),
                Util.Seed);
            perm = Util.AlphabetPerms;
            key =   string.Join("",keyPerm).Substring(0,n%26);
        }
        public Vigenere():this(Util.Seed)
        {

        }
     
        public override string Criptare(string textClar)
        {
            string textCriptat = "";

       
            for(int i=0;i<textClar.Length;i++)
            {
                if (!char.IsLetter(textClar[i]))
                    textCriptat += textClar[i];
                else
                {
                    char linie = key[i % key.Length];
                
                 
                    char coloana = char.ToLower(textClar[i]);

                    if (Util.IsUpperCase(textClar[i]))
                        textCriptat += char.ToUpper(perm[linie - 'a', coloana - 'a']);
                    else
                        textCriptat += perm[linie - 'a', coloana - 'a'];
               
                     


                }
            }
            return textCriptat;
        }

        public override string Decriptare(string textCriptat)
        {
            string textClar = "";

          for(int i=0;i<textCriptat.Length;i++)
            {
                if (!char.IsLetter(textCriptat[i]))
                    textClar += textCriptat[i];
                else
                {
                    char linie = key[i % key.Length];
                   char original = Util.ShiftLetter(textCriptat[i],-(linie-'a'));
                    if (Util.IsUpperCase(textCriptat[i]))
                        textClar += char.ToUpper(original);
                    else
                        textClar += original;
                    

                }
            }
            return textClar;
        }
    }
}
