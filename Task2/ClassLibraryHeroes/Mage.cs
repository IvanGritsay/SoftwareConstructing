using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public class Mage : IHero
    {
        private string name;
        private int health = 100;
        private int damage = 30;

        public Mage(string name)
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine(name + " використовує магію");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Маг: " + name + ", Здоров'я: " + health + ", Атака: " + damage);
        }
    }

}
