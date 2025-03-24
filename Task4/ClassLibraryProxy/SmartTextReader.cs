using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProxy
{
    public class SmartTextReader : ITextReader
    {
        public char[][] ReadFile(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                char[][] result = new char[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    result[i] = lines[i].ToCharArray();
                }

                return result;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }
}
