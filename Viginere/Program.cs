using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Viginere
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../textclar.txt");
            StreamWriter writer = new StreamWriter("../../textcriptat.txt");
            string key = reader.ReadLine();
            string line;
            Vigenere vig = new Vigenere(key);
            while((line=reader.ReadLine()) !=null)
            {
              
                writer.WriteLine(vig.Criptare(line));
            }
            reader.Close();
            writer.Close();

        }
    }
}
