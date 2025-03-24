using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public abstract class InventoryDecorator : IHero
    {
        protected IHero hero;

        public InventoryDecorator(IHero hero)
        {
            this.hero = hero;
        }

        public virtual void Attack()
        {
            hero.Attack();
        }

        public virtual void DisplayInfo()
        {
            hero.DisplayInfo();
        }
    }
}
