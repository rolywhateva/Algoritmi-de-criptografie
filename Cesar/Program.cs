using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Cesar
{
    public class Program
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../textclar.txt"))
            {
                
                Cesar encoder = new Cesar();
                using (StreamWriter writer = new StreamWriter("../../textcriptat.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(encoder.Criptare(line.Trim()));
                    }
                    writer.Close();
                    reader.Close();
                }
            }

        }
    }
}
