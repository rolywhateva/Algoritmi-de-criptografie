using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Utils;
using CifruN;
using Encoder = CifruN.CifruN;
using CryptType = AlgoritmiIstorici.AlgoritmCriptare;
namespace Cesar
{
    class Cesar :CryptType
    {
        private Encoder encoder = new Encoder(3);

        public override string Criptare(string textClar)
        {
            return this.encoder.Criptare(textClar);
        }
        public override string Decriptare(string textCriptat)
        {
            return this.encoder.Decriptare(textCriptat);
        }
    }
}
