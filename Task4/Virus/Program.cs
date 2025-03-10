using System;
using System.Collections.Generic;
using System.Text;

public interface IPrototype<T>
{
    T Clone();
}

public class Virus : IPrototype<Virus>
{
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string species, double weight, int age)
    {
        Name = name;
        Species = species;
        Weight = weight;
        Age = age;
    }

    public Virus Clone()
    {
        Virus clone = new Virus(Name, Species, Weight, Age);
        foreach (var child in Children)
        {
            clone.Children.Add(child.Clone());
        }
        return clone;
    }

    public void PrintInfo(string indent = "")
    {
        Console.WriteLine($"{indent}Вірус {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}");
        foreach (var child in Children)
        {
            child.PrintInfo(indent + "  ");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding= Encoding.UTF8;
        Virus parentVirus = new Virus("Alpha", "COVID-19", 0.003, 1);
        Virus child1 = new Virus("Beta", "COVID-19", 0.002, 1);
        Virus child2 = new Virus("Gamma", "COVID-19", 0.0025, 2);

        parentVirus.Children.Add(child1);
        parentVirus.Children.Add(child2);

        Virus grandChild1 = new Virus("Delta", "COVID-19", 0.0018, 1);
        child1.Children.Add(grandChild1);

        Console.WriteLine("Оригінальне сімейство вірусів:");
        parentVirus.PrintInfo();

        Virus clonedVirus = parentVirus.Clone();

        Console.WriteLine("\nКлоноване сімейство вірусів:");
        clonedVirus.PrintInfo();
        Console.ReadLine();
    }
}
