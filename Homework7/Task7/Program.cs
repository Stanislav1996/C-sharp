using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter writer1 = new StreamWriter("text1.txt"))
                {
                    using (StreamWriter writer2 = new StreamWriter("text2.txt"))
                    {
                        string line = reader.ReadLine();
                        int linenumber = 0;
                        while (line != null)
                        {
                            if (linenumber % 2 == 0)
                            {
                                writer1.WriteLine(line);
                            }
                            else
                            {
                                writer2.WriteLine(line);
                            }
                            line = reader.ReadLine();
                            linenumber++;
                        }
                    }

                }

            }
        }
}
