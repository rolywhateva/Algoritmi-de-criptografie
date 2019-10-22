using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmiIstorici;
using static Utils.Utils;
namespace CifruN
{
 public class CifruN :AlgoritmiIstorici.AlgoritmCriptare
    {
      
        public  CifruN(int cheie)
        {
            this.cheie = cheie;
        }
       public CifruN() : this(Seed)
        {

        }
        private int cheie;
        public int Cheie
        {
            get
            {
                return cheie;
            }
        }
       
      
        public override string Criptare(string textClar)
        {
            return ShiftAllLetters(textClar, this.cheie);
        }
        public override string Decriptare(string textCriptat)
        {
            return ShiftAllLetters(textCriptat, -this.cheie);

        }
        public static string CriptoAnaliza(string text,HashSet<string> set,int cheie,out int nr)
        {
            CifruN encoder = new CifruN(cheie);
            string result = encoder.Decriptare(text);
            string[] cuv = result.Split(new char[] { ',', '.', '-', '!', '?', ' ', '`', '/', '\\', '!', ';' },
                StringSplitOptions.RemoveEmptyEntries);
             nr = 0;
            for (int i = 0; i < cuv.Length; i++)
            {
                if (set.Contains(cuv[i].ToLower()))
                    nr++;
            }
            return result;
     
        }
    }
}
