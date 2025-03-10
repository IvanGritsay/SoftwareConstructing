using BuilderClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CharacterDirector director = new CharacterDirector();

            HeroBuilder heroBuilder = new HeroBuilder("Артур");
            Character hero = director.CreateHero(heroBuilder);
            Console.WriteLine("Герой:");
            Console.WriteLine(hero);  

            EnemyBuilder enemyBuilder = new EnemyBuilder("Мордред");
            Character enemy = director.CreateEnemy(enemyBuilder);
            Console.WriteLine("\nВорог:");
            Console.WriteLine(enemy);
            Console.ReadLine();
        }
    }
}
