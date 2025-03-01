using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IInventory
    {
        void AddAnimal(Animal animal);
        void AddEmployee(IEmployee employee);
        void ShowInventory();
    }
}
