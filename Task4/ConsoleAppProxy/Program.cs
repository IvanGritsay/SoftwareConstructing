using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryProxy;
using System.IO;

namespace ConsoleAppProxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            File.WriteAllText("test.txt", "example text\ntest file.");
            File.WriteAllText("restricted_data.config", "configuration\nsecret data");

            ITextReader realReader = new SmartTextReader();

            ITextReader checkedReader = new SmartTextChecker(realReader);
            char[][] content = checkedReader.ReadFile("test.txt");
            if (content != null)
            {
                Console.WriteLine("\nfile content:");
                foreach (var line in content)
                {
                    Console.WriteLine(new string(line));
                }
            }

            ITextReader lockedReader = new SmartTextReaderLocker(realReader, @"restricted_.*\.config");
            lockedReader.ReadFile("test.txt");
            lockedReader.ReadFile("restricted_data.config");
        }
    }
}