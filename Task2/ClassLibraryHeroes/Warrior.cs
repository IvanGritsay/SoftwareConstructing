using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHeroes
{
    public class Warrior : IHero
    {
        private string name;
        private int health = 150;
        private int damage = 20;

        public Warrior(string name)
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine(name + " атакує мечем");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Воїн: " + name + ", Здоров'я: " + health + ", Атака: " + damage);
        }
    }
}
