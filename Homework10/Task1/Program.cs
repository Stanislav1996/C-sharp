using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string errormessage = null;
            string path = "exception.txt";
            string path1 = "exceptionswrite.txt";
            string text = "Bla bla bla, sha lq lq lqlq , muhahaha ";
            try
            {
                Console.WriteLine(Read(path));
                Console.WriteLine(Write(path1, text));
            }
            catch (DirectoryNotFoundException dnfe)
            {
                errormessage = dnfe.Message;
            }
            catch (FileNotFoundException fnfe)
            {
                errormessage = fnfe.Message;
            }
            catch (Exception ex)
            {
                errormessage = ex.Message;
            }
            finally
            {
                if (errormessage != null)
                {
                    Console.WriteLine(errormessage);
                }
            }

        }
        public static string Read(string path)
        {
            string linereader;
            using (StreamReader read = new StreamReader(path))
            {
                linereader = read.ReadToEnd();
            }
            return linereader;
        }
        static string Write(string path1, string text)
        {
            using (StreamWriter write = new StreamWriter("exceptionswrite.txt"))
            {
                write.WriteLine(text);
            }
            return text;
        }
    }
    }
}
