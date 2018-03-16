using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWriteCW
{
    class Program
    {
        static String filename = @"C:\Users\Default\Documents\csGenText.txt";
        static String content = "I wrote a thing";
        static String reWritten = "I wrote a thing and can edit it";

        static void Main(string[] args)
        {
            
            File.WriteAllText(filename, content);
            Console.WriteLine("file written, press enter to re-write");
            Console.ReadLine();
            reWrite();
            Console.WriteLine("file re-written, press enter to delete");
            Console.ReadLine();
            deleter();
            
        }

        static void reWrite()
        {
            File.WriteAllText(filename, reWritten);
        }

        static void deleter()
        {
            File.Delete(filename);
        }





    }
}
