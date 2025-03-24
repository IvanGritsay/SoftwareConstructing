using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public class Paladin : IHero
    {
        private string name;
        private int health = 200;
        private int damage = 15;

        public Paladin(string name)
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine(name + " б'є молотом");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Паладін: " + name + ", Здоров'я: " + health + ", Атака: " + damage);
        }
    }

}
