using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SmartphonesClassLibrary;

namespace FactoryClassLibrary
{
    public class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new KiaomiLaptop();
        public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
    }
}
