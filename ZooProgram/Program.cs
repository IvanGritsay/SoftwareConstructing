using System;
using System.Text;
using ClassLibrary;

namespace ZooProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            var lion = new Lion { Name = "Сімба", Age = 5 };
            var elephant = new Elephant { Name = "Дамбо", Age = 8 };

            var meat = new Food("М'ясо", 10);
            var vegetables = new Food("Овочі", 20);

            lion.Eat(meat);
            elephant.Eat(vegetables);

            var enclosure = new Enclosure("Саванна", 1000);
            enclosure.AddAnimal(lion);
            enclosure.AddAnimal(elephant);

            var zooEmployee = new Employee("Іван", "Доглядач");

            var inventory = new Inventory();
            inventory.AddAnimal(lion);
            inventory.AddAnimal(elephant);
            inventory.AddEmployee(zooEmployee);

            inventory.ShowInventory();
            Console.ReadLine();
        }
    }
}
