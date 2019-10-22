using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Utils;
using System.IO;

namespace CifruN
{
    class Program
    {
        
        static void Main(string[] args)
        {
          
            #region Citire din textclar.txt si scriere in textcriptat.txt 
            using (StreamReader reader = new StreamReader("../../textclar.txt"))
            {
                string line;
                int cheie = 3;
                try
                {
                     cheie = int.Parse(reader.ReadLine().Trim());
                } catch(Exception e)
                {
                    Console.WriteLine("Nu s-a gasit pe prima linie cheia!");
                }
                CifruN encoder = new CifruN(cheie);
                using (StreamWriter writer = new StreamWriter("../../textcriptat.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(encoder.Criptare(line.Trim()));
                    }
                    writer.Close();
                    reader.Close();
                }
            }
            #endregion
           
        }
    }
}
