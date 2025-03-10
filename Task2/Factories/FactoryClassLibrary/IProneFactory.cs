using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SmartphonesClassLibrary;

namespace FactoryClassLibrary
{
    public class IProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new IProneLaptop();
        public ISmartphone CreateSmartphone() => new IProneSmartphone();
    }
}
