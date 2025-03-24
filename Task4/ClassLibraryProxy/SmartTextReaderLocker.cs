using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryProxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private ITextReader _realSubject;
        private Regex _pattern;

        public SmartTextReaderLocker(ITextReader realSubject, string pattern)
        {
            _realSubject = realSubject;
            _pattern = new Regex(pattern);
        }

        public char[][] ReadFile(string filename)
        {
            if (_pattern.IsMatch(filename))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                return _realSubject.ReadFile(filename);
            }
        }
    }
}
