using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphonesClassLibrary
{
    public class IProneSmartphone : ISmartphone
    {
        public void ShowSmartphone() => Console.WriteLine("Smartphone від IProne");
    }
}
