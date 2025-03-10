using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class IProneLaptop : ILaptop
    {
        public void ShowLaptop() => Console.WriteLine("Laptop від IProne");
    }
}
