using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Enclosure
    {
        public string Type { get; set; }
        public double Size { get; set; }

        public Enclosure(string type, double size)
        {
            Type = type;
            Size = size;
        }

        public void AddAnimal(Animal animal)
        {
            Console.WriteLine($"{animal.Name} додано до вольєра типу {Type}.");
        }
    }

}
