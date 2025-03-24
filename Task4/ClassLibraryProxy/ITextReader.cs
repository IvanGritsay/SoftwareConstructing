using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProxy
{
    public interface ITextReader
    {
        char[][] ReadFile(string filename);
    }
}
