using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliAlfabetic
{
    class Letter
    {
        private char character;
        private int frequency;
        public char Character
        {
            get
            {
                return character;
            }
         }
        public int Frequency
        {
            get
            {
                return frequency;
            }
        }
        public Letter(char character, int frequency)
        {
            this.character = character;
            this.frequency = frequency;

        }
        public static Letter[] FromDictionary(Dictionary<char,int> freq)
        {
            Letter[] letters = new Letter[freq.Keys.Count];
            int i = 0;
            foreach(var key in freq.Keys)
            {
                letters[i] = new Letter(key, freq[key]);
                i++;
            }
            return letters;
        }



      
    }
}
