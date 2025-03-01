using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lion : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine($"{Name} споживає {food.Type}.");
        }
    }
}
