using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientClassLibrary;
using FactoryClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Продукти IProne:");
            Client client1 = new Client(new IProneFactory());
            client1.ShowProducts();

            Console.WriteLine("\nПродукти Kiaomi:");
            Client client2 = new Client(new KiaomiFactory());
            client2.ShowProducts();
            Console.ReadLine();
        }
    }
}
