using System;

class Relative
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Relationship { get; set; }

    public Relative(string name, int age, string relationship)
    {
        Name = name;
        Age = age;
        Relationship = relationship;
    }

    public void PrintProperties()
    {
        Console.WriteLine($"Name - {Name}");
        Console.WriteLine($"Age - {Age}");
        Console.WriteLine($"Relationship - {Relationship}");
    }
}

class Program {
    public static void Main(string[] args){
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter relationship: ");
        string relationship = Console.ReadLine();

        Relative myRelative = new Relative(name, age, relationship);
        myRelative.PrintProperties();
    }
}