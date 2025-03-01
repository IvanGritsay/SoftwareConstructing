using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Inventory : IInventory
    {
        private List<Animal> animals = new List<Animal>();
        private List<IEmployee> employees = new List<IEmployee>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void ShowInventory()
        {
            Console.WriteLine("Тварини в зоопарку:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name}, вік: {animal.Age}");
            }

            Console.WriteLine("\nПрацівники:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, посада: {employee.Role}");
            }
        }
    }
}
