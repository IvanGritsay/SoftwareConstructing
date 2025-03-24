using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using ClassLibraryHeroes;

namespace ConsoleAppHeroes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IHero warrior = new Warrior("Лицар дракона");
            IHero mage = new Mage("Інвокер");
            IHero paladin = new Paladin("Варлок");

            warrior = new Armor(warrior);
            warrior = new Sword(warrior);

            mage = new Amulet(mage);

            paladin = new Armor(paladin);
            paladin = new Sword(paladin);
            paladin = new Amulet(paladin);

            warrior.DisplayInfo();
            warrior.Attack();
            Console.WriteLine();
            mage.DisplayInfo();
            mage.Attack();
            Console.WriteLine();

            paladin.DisplayInfo();
            paladin.Attack();
        }
    }
}
