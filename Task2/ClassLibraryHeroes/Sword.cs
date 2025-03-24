using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public class Sword : InventoryDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Озброєний мечем (+10 атаки)");
        }
    }
}
