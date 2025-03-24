using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibraryAdapter
{
    public class FileWriter
    {
        private string _filename;

        public FileWriter(string filename)
        {
            _filename = filename;
        }

        public void Write(string message)
        {
            File.AppendAllText(_filename, message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(_filename, message + Environment.NewLine);
        }
    }
}
