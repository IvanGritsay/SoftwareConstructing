using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Animal : IEatable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Eat(Food food);
    }
}

