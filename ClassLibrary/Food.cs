using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Food
    {
        public string Type { get; set; }
        public int Quantity { get; set; }

        public Food(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }
    }
}
