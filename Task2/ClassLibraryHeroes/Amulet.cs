using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public class Amulet : InventoryDecorator
    {
        public Amulet(IHero hero) : base(hero) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Має амулет (+20 здоров'я, +5 атаки)");
        }
    }
}
