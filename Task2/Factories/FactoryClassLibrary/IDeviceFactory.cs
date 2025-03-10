using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SmartphonesClassLibrary;

namespace FactoryClassLibrary
{
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        ISmartphone CreateSmartphone();
    }
}
