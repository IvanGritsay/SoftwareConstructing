using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SmartphonesClassLibrary;
using FactoryClassLibrary;
namespace ClientClassLibrary
{
    public class Client
    {
        private readonly ILaptop _laptop;
        private readonly ISmartphone _smartphone;

        public Client(IDeviceFactory factory)
        {
            _laptop = factory.CreateLaptop();
            _smartphone = factory.CreateSmartphone();
        }

        public void ShowProducts()
        {
            _laptop.ShowLaptop();
            _smartphone.ShowSmartphone();
        }
    }
}
