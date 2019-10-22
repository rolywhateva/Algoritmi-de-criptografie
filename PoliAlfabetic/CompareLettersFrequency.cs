using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliAlfabetic
{
    class LetterFrequencyComparer : IComparer<Letter>
    {
        private int sign;
        public LetterFrequencyComparer(bool  descending = true)
        {
            if (descending)
                sign = -1;
            else
                sign = 1;

        }
        public int Compare(Letter x, Letter y)
        {
            if (x.Frequency < y.Frequency)
                return -sign;
            if (x.Frequency > y.Frequency)
                return  sign;
            return 0;
        }
    }
}
