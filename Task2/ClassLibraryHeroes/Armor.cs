using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public class Armor : InventoryDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Одягнений в броню (+50 здоров'я)");
        }
    }
}
